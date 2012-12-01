using System;
using System.IO;
using System.Windows.Forms;

namespace SteganoWave
{
	
	public class WaveUtility
	{
		
		private WaveStream sourceStream;
		
		
		private Stream destinationStream;
		
		
		private int bytesPerSample;

		
		public WaveUtility(WaveStream sourceStream, Stream destinationStream):this(sourceStream)
        {
			this.destinationStream = destinationStream;
		}

			public WaveUtility(WaveStream sourceStream) 
        {
			this.sourceStream = sourceStream;
			this.bytesPerSample = sourceStream.Format.wBitsPerSample / 8;
		}

				public void Hide(Stream messageStream, Stream keyStream)
                {
			
			byte[] waveBuffer = new byte[bytesPerSample];
			byte message, bit, waveByte;
			int messageBuffer; 
			int keyByte; 
			
			while( (messageBuffer=messageStream.ReadByte()) >= 0 ){
				
				message = (byte)messageBuffer;
				
				
				for(int bitIndex=0; bitIndex<8; bitIndex++)
                {
					
					
					keyByte = GetKeyValue(keyStream);
					
					
                    for (int n=0; n<keyByte-1; n++)
                    {
						
						sourceStream.Copy(waveBuffer, 0, waveBuffer.Length, destinationStream);
					}

					
					sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
					waveByte = waveBuffer[bytesPerSample-1];
					
					
					bit = (byte)(((message & (byte)(1 << bitIndex)) > 0) ? 1 : 0);
						
					
					if((bit == 1) && ((waveByte % 2) == 0))
                    {                        
                        waveByte += 1;
					}
                    else if((bit == 0) && ((waveByte % 2) == 1))
                    {
                        waveByte -= 1;
					}

					waveBuffer[bytesPerSample-1] = waveByte;

					
					destinationStream.Write(waveBuffer, 0, bytesPerSample);
				}
			}

			
			waveBuffer = new byte[sourceStream.Length - sourceStream.Position];
			sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
			destinationStream.Write(waveBuffer, 0, waveBuffer.Length);
		}

		
		public void Extract(Stream messageStream, Stream keyStream){
		
			byte[] waveBuffer = new byte[bytesPerSample];
			byte message, bit, waveByte;
			int messageLength = 0; 
			int keyByte; 
			
			while( (messageLength==0 || messageStream.Length<messageLength) ){
				
				message = 0;
				
				
				for(int bitIndex=0; bitIndex<8; bitIndex++){

					
					keyByte = GetKeyValue(keyStream);
					
					
					for(int n=0; n<keyByte-1; n++)
                    {
						
						sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
					}
                    sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
					waveByte = waveBuffer[bytesPerSample-1];
					
					
					bit = (byte)(((waveByte % 2) == 0) ? 0 : 1);

					
					message += (byte)(bit << bitIndex);
				}

				
				messageStream.WriteByte(message);
				
				if(messageLength==0 && messageStream.Length==4)
                {
					
					messageStream.Seek(0, SeekOrigin.Begin);
					messageLength = new BinaryReader(messageStream).ReadInt32();
					messageStream.Seek(0, SeekOrigin.Begin);
					messageStream.SetLength(0);
				}
			}

		}
		
		
		public static long CheckKeyForMessage(Stream keyStream, long messageLength){
			long messageLengthBits = messageLength * 8;
			long countRequiredSamples = 0;

			if (messageLengthBits > keyStream.Length)
			{
				long keyLength = keyStream.Length;

				
				byte[] keyBytes = new byte[keyLength];
				keyStream.Read(keyBytes, 0, keyBytes.Length);

				
				countRequiredSamples = SumKeyArray(keyBytes);
                
				double countKeyCopies = messageLengthBits / keyLength;
                
				countRequiredSamples = (long)(countRequiredSamples * countKeyCopies);
                
            }
			else
			{
				byte[] keyBytes = new byte[messageLengthBits];
				keyStream.Read(keyBytes, 0, keyBytes.Length);
				countRequiredSamples = SumKeyArray(keyBytes);
			}

			keyStream.Seek(0, SeekOrigin.Begin);
			return countRequiredSamples;
		}

		private static long SumKeyArray(byte[] values)
		{
			long sum = 0;
			foreach (int value in values)
			{	
				sum += (value == 0) ? 1 : value;
			}
			return sum;
		}
		
		
		private static byte GetKeyValue(Stream keyStream)
        {
			int keyValue;
			if( (keyValue=keyStream.ReadByte()) < 0){
				keyStream.Seek(0, SeekOrigin.Begin);
				keyValue=keyStream.ReadByte();
				if(keyValue == 0){ keyValue=1; }
			}
			return (byte)keyValue;
		}
	}
}
