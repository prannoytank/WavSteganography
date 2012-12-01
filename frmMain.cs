using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;

namespace SteganoWave
{
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtSrcFile;
		private System.Windows.Forms.Button btnSrcFile;
		private System.Windows.Forms.Button btnDstFile;
		private System.Windows.Forms.TextBox txtDstFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.TabControl tabCtl;
		private System.Windows.Forms.TabPage tabHide;
		private System.Windows.Forms.TabPage tabExtract;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnExtract;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnKeyFile;
		private System.Windows.Forms.TextBox txtKeyFile;
		private System.Windows.Forms.TextBox txtExtractedMessage;
        private System.Windows.Forms.RadioButton rdoSrcFile;
		private System.Windows.Forms.RadioButton rdoMsgFile;
		private System.Windows.Forms.TextBox txtMsgFile;
		private System.Windows.Forms.RadioButton rdoMsgText;
		private System.Windows.Forms.RadioButton rdoMessageDisplay;
		private System.Windows.Forms.RadioButton rdoMessageDstFile;
		private System.Windows.Forms.TextBox txtMessageDstFile;
		private System.Windows.Forms.Button btnMsgFile1;
		private System.Windows.Forms.Button btnMessageDstFile;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private IContainer components;

		public frmMain(){
			InitializeComponent();
		}

		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
				private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.txtSrcFile = new System.Windows.Forms.TextBox();
            this.btnSrcFile = new System.Windows.Forms.Button();
            this.btnDstFile = new System.Windows.Forms.Button();
            this.txtDstFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tabCtl = new System.Windows.Forms.TabControl();
            this.tabHide = new System.Windows.Forms.TabPage();
            this.rdoMsgText = new System.Windows.Forms.RadioButton();
            this.btnMsgFile1 = new System.Windows.Forms.Button();
            this.txtMsgFile = new System.Windows.Forms.TextBox();
            this.rdoMsgFile = new System.Windows.Forms.RadioButton();
            this.tabExtract = new System.Windows.Forms.TabPage();
            this.btnMessageDstFile = new System.Windows.Forms.Button();
            this.txtMessageDstFile = new System.Windows.Forms.TextBox();
            this.rdoMessageDisplay = new System.Windows.Forms.RadioButton();
            this.rdoMessageDstFile = new System.Windows.Forms.RadioButton();
            this.txtExtractedMessage = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKeyFile = new System.Windows.Forms.Button();
            this.txtKeyFile = new System.Windows.Forms.TextBox();
            this.rdoSrcFile = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCtl.SuspendLayout();
            this.tabHide.SuspendLayout();
            this.tabExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrcFile
            // 
            this.errorProvider.SetIconAlignment(this.txtSrcFile, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtSrcFile.Location = new System.Drawing.Point(209, 12);
            this.txtSrcFile.Name = "txtSrcFile";
            this.txtSrcFile.Size = new System.Drawing.Size(318, 20);
            this.txtSrcFile.TabIndex = 0;
            this.txtSrcFile.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // btnSrcFile
            // 
            this.btnSrcFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSrcFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrcFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSrcFile.Location = new System.Drawing.Point(545, 8);
            this.btnSrcFile.Name = "btnSrcFile";
            this.btnSrcFile.Size = new System.Drawing.Size(80, 30);
            this.btnSrcFile.TabIndex = 1;
            this.btnSrcFile.Text = "Browse...";
            this.btnSrcFile.UseVisualStyleBackColor = false;
            this.btnSrcFile.Click += new System.EventHandler(this.btnSrcFile_Click);
            // 
            // btnDstFile
            // 
            this.btnDstFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDstFile.Location = new System.Drawing.Point(495, 18);
            this.btnDstFile.Name = "btnDstFile";
            this.btnDstFile.Size = new System.Drawing.Size(85, 24);
            this.btnDstFile.TabIndex = 1;
            this.btnDstFile.Text = "Browse...";
            this.btnDstFile.Click += new System.EventHandler(this.btnDstFile_Click);
            // 
            // txtDstFile
            // 
            this.errorProvider.SetIconAlignment(this.txtDstFile, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtDstFile.Location = new System.Drawing.Point(162, 18);
            this.txtDstFile.Name = "txtDstFile";
            this.txtDstFile.Size = new System.Drawing.Size(319, 22);
            this.txtDstFile.TabIndex = 0;
            this.txtDstFile.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save Result as";
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(247, 205);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(137, 26);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Hide Message";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtMessage
            // 
            this.errorProvider.SetIconAlignment(this.txtMessage, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtMessage.Location = new System.Drawing.Point(162, 86);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(315, 111);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.txtMessage.Enter += new System.EventHandler(this.txtMessage_Enter);
            // 
            // tabCtl
            // 
            this.tabCtl.Controls.Add(this.tabHide);
            this.tabCtl.Controls.Add(this.tabExtract);
            this.tabCtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtl.Location = new System.Drawing.Point(46, 149);
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
            this.tabCtl.Size = new System.Drawing.Size(606, 273);
            this.tabCtl.TabIndex = 5;
            this.tabCtl.SelectedIndexChanged += new System.EventHandler(this.tabCtl_SelectedIndexChanged);
            // 
            // tabHide
            // 
            this.tabHide.Controls.Add(this.rdoMsgText);
            this.tabHide.Controls.Add(this.btnMsgFile1);
            this.tabHide.Controls.Add(this.txtMsgFile);
            this.tabHide.Controls.Add(this.rdoMsgFile);
            this.tabHide.Controls.Add(this.txtMessage);
            this.tabHide.Controls.Add(this.btnHide);
            this.tabHide.Controls.Add(this.label2);
            this.tabHide.Controls.Add(this.btnDstFile);
            this.tabHide.Controls.Add(this.txtDstFile);
            this.tabHide.Location = new System.Drawing.Point(4, 25);
            this.tabHide.Name = "tabHide";
            this.tabHide.Size = new System.Drawing.Size(598, 244);
            this.tabHide.TabIndex = 0;
            this.tabHide.Text = "Hide";
            // 
            // rdoMsgText
            // 
            this.rdoMsgText.Checked = true;
            this.rdoMsgText.Location = new System.Drawing.Point(26, 86);
            this.rdoMsgText.Name = "rdoMsgText";
            this.rdoMsgText.Size = new System.Drawing.Size(102, 25);
            this.rdoMsgText.TabIndex = 8;
            this.rdoMsgText.TabStop = true;
            this.rdoMsgText.Text = "Hide Text";
            this.rdoMsgText.CheckedChanged += new System.EventHandler(this.rdoContent_CheckedChanged);
            // 
            // btnMsgFile1
            // 
            this.btnMsgFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsgFile1.Location = new System.Drawing.Point(495, 51);
            this.btnMsgFile1.Name = "btnMsgFile1";
            this.btnMsgFile1.Size = new System.Drawing.Size(85, 26);
            this.btnMsgFile1.TabIndex = 7;
            this.btnMsgFile1.Text = "Browse...";
            this.btnMsgFile1.Click += new System.EventHandler(this.btnMsgFile_Click);
            // 
            // txtMsgFile
            // 
            this.errorProvider.SetIconAlignment(this.txtMsgFile, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtMsgFile.Location = new System.Drawing.Point(162, 51);
            this.txtMsgFile.Name = "txtMsgFile";
            this.txtMsgFile.Size = new System.Drawing.Size(319, 22);
            this.txtMsgFile.TabIndex = 6;
            this.txtMsgFile.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.txtMsgFile.Enter += new System.EventHandler(this.txtMsgFile_Enter);
            // 
            // rdoMsgFile
            // 
            this.rdoMsgFile.Location = new System.Drawing.Point(26, 51);
            this.rdoMsgFile.Name = "rdoMsgFile";
            this.rdoMsgFile.Size = new System.Drawing.Size(145, 26);
            this.rdoMsgFile.TabIndex = 5;
            this.rdoMsgFile.Text = "Hide Content of File";
            this.rdoMsgFile.CheckedChanged += new System.EventHandler(this.rdoContent_CheckedChanged);
            // 
            // tabExtract
            // 
            this.tabExtract.Controls.Add(this.btnMessageDstFile);
            this.tabExtract.Controls.Add(this.txtMessageDstFile);
            this.tabExtract.Controls.Add(this.rdoMessageDisplay);
            this.tabExtract.Controls.Add(this.rdoMessageDstFile);
            this.tabExtract.Controls.Add(this.txtExtractedMessage);
            this.tabExtract.Controls.Add(this.btnExtract);
            this.tabExtract.Location = new System.Drawing.Point(4, 25);
            this.tabExtract.Name = "tabExtract";
            this.tabExtract.Size = new System.Drawing.Size(598, 244);
            this.tabExtract.TabIndex = 1;
            this.tabExtract.Text = "Extract";
            // 
            // btnMessageDstFile
            // 
            this.btnMessageDstFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageDstFile.Location = new System.Drawing.Point(502, 17);
            this.btnMessageDstFile.Name = "btnMessageDstFile";
            this.btnMessageDstFile.Size = new System.Drawing.Size(86, 25);
            this.btnMessageDstFile.TabIndex = 12;
            this.btnMessageDstFile.Text = "Browse...";
            this.btnMessageDstFile.Click += new System.EventHandler(this.btnMessageDstFile_Click);
            // 
            // txtMessageDstFile
            // 
            this.errorProvider.SetIconAlignment(this.txtMessageDstFile, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtMessageDstFile.Location = new System.Drawing.Point(172, 17);
            this.txtMessageDstFile.Name = "txtMessageDstFile";
            this.txtMessageDstFile.Size = new System.Drawing.Size(319, 22);
            this.txtMessageDstFile.TabIndex = 11;
            this.txtMessageDstFile.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.txtMessageDstFile.Enter += new System.EventHandler(this.txtMessageDstFile_Enter);
            // 
            // rdoMessageDisplay
            // 
            this.rdoMessageDisplay.Checked = true;
            this.rdoMessageDisplay.Location = new System.Drawing.Point(26, 51);
            this.rdoMessageDisplay.Name = "rdoMessageDisplay";
            this.rdoMessageDisplay.Size = new System.Drawing.Size(119, 43);
            this.rdoMessageDisplay.TabIndex = 10;
            this.rdoMessageDisplay.TabStop = true;
            this.rdoMessageDisplay.Text = "Display Message";
            // 
            // rdoMessageDstFile
            // 
            this.rdoMessageDstFile.Location = new System.Drawing.Point(26, 14);
            this.rdoMessageDstFile.Name = "rdoMessageDstFile";
            this.rdoMessageDstFile.Size = new System.Drawing.Size(140, 25);
            this.rdoMessageDstFile.TabIndex = 9;
            this.rdoMessageDstFile.Text = "Save Message as";
            this.rdoMessageDstFile.CheckedChanged += new System.EventHandler(this.rdoMessageDstFile_CheckedChanged);
            // 
            // txtExtractedMessage
            // 
            this.errorProvider.SetIconAlignment(this.txtExtractedMessage, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtExtractedMessage.Location = new System.Drawing.Point(173, 60);
            this.txtExtractedMessage.Multiline = true;
            this.txtExtractedMessage.Name = "txtExtractedMessage";
            this.txtExtractedMessage.Size = new System.Drawing.Size(316, 103);
            this.txtExtractedMessage.TabIndex = 7;
            this.txtExtractedMessage.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.txtExtractedMessage.Enter += new System.EventHandler(this.txtExtractedMessage_Enter);
            // 
            // btnExtract
            // 
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(247, 205);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(137, 26);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "Extract Message";
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(94, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Key File";
            // 
            // btnKeyFile
            // 
            this.btnKeyFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKeyFile.Location = new System.Drawing.Point(545, 75);
            this.btnKeyFile.Name = "btnKeyFile";
            this.btnKeyFile.Size = new System.Drawing.Size(80, 28);
            this.btnKeyFile.TabIndex = 1;
            this.btnKeyFile.Text = "Browse...";
            this.btnKeyFile.UseVisualStyleBackColor = false;
            this.btnKeyFile.Click += new System.EventHandler(this.btnKeyFile_Click);
            // 
            // txtKeyFile
            // 
            this.errorProvider.SetIconAlignment(this.txtKeyFile, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtKeyFile.Location = new System.Drawing.Point(209, 81);
            this.txtKeyFile.Name = "txtKeyFile";
            this.txtKeyFile.Size = new System.Drawing.Size(318, 20);
            this.txtKeyFile.TabIndex = 0;
            this.txtKeyFile.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // rdoSrcFile
            // 
            this.rdoSrcFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSrcFile.ForeColor = System.Drawing.Color.Red;
            this.rdoSrcFile.Location = new System.Drawing.Point(76, 12);
            this.rdoSrcFile.Name = "rdoSrcFile";
            this.rdoSrcFile.Size = new System.Drawing.Size(89, 22);
            this.rdoSrcFile.TabIndex = 6;
            this.rdoSrcFile.Text = "Wave File";
            this.rdoSrcFile.CheckedChanged += new System.EventHandler(this.rdoCarrierWave_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(752, 503);
            this.Controls.Add(this.rdoSrcFile);
            this.Controls.Add(this.tabCtl);
            this.Controls.Add(this.btnSrcFile);
            this.Controls.Add(this.txtSrcFile);
            this.Controls.Add(this.txtKeyFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKeyFile);
            this.Name = "frmMain";
            this.Text = "SteganoWave";
            this.tabCtl.ResumeLayout(false);
            this.tabHide.ResumeLayout(false);
            this.tabHide.PerformLayout();
            this.tabExtract.ResumeLayout(false);
            this.tabExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void btnSrcFile_Click(object sender, System.EventArgs e)
        {
			
			OpenFileDialog dlg = new OpenFileDialog();
			GetFileName(dlg, txtSrcFile, true);
		}

		private void btnDstFile_Click(object sender, System.EventArgs e)
        {
			
			SaveFileDialog dlg = new SaveFileDialog();
			GetFileName(dlg, txtDstFile, true);
		}

		private void btnKeyFile_Click(object sender, System.EventArgs e) 
        {
			
			OpenFileDialog dlg = new OpenFileDialog();
			GetFileName(dlg, txtKeyFile, false);
		}

		
		private void btnMsgFile_Click(object sender, System.EventArgs e)
        {
			
			OpenFileDialog dlg = new OpenFileDialog();
			GetFileName(dlg, txtMsgFile, false);
			rdoMsgFile.Checked = true;
		}
		
		private void btnMessageDstFile_Click(object sender, System.EventArgs e) 
        {
			
			SaveFileDialog dlg = new SaveFileDialog();
			GetFileName(dlg, txtMessageDstFile, false);
			rdoMessageDstFile.Checked = true;
		}

		private void btnHide_Click(object sender, System.EventArgs e)
        {
		


			if(rdoSrcFile.Checked && (txtSrcFile.Text.Length == 0)){
				errorProvider.SetError(txtSrcFile, "You forgot to choose a carrier file.");
			}
			else if(txtKeyFile.Text.Length == 0){
				errorProvider.SetError(txtKeyFile, "You forgot to choose a key file.");
			}
			else if(txtDstFile.Text.Length == 0){
				errorProvider.SetError(txtDstFile, "The resulting carrier file must be saved somewhere.");
			}
			else if(rdoMsgFile.Checked && (txtMsgFile.Text.Length == 0)){
				errorProvider.SetError(txtMsgFile, "What am I supposed to hide?");
			}
			else if(rdoMsgText.Checked && (txtMessage.Text.Length == 0)){
				errorProvider.SetError(txtMessage, "What am I supposed to hide?");
			}
			else{
                MessageBox.Show("alert");
				Stream sourceStream = null;
				FileStream destinationStream = null;
				WaveStream audioStream = null;
			
				
				Stream messageStream = GetMessageStream();
				
				Stream keyStream = new FileStream(txtKeyFile.Text, FileMode.Open);
			
				try {
				
					
					long countSamplesRequired = WaveUtility.CheckKeyForMessage(keyStream, messageStream.Length);
				
					if(countSamplesRequired > Int32.MaxValue){
						throw new Exception("Message too long, or bad key! This message/key combination requires "+countSamplesRequired+" samples, only "+Int32.MaxValue+" samples are allowed.");
					}

					if(rdoSrcFile.Checked)
                    { 
						sourceStream = new FileStream(txtSrcFile.Text, FileMode.Open);
					}
                    else
                    { 					}

					this.Cursor = Cursors.WaitCursor;
				
					
					destinationStream = new FileStream(txtDstFile.Text, FileMode.Create);
				
					
					audioStream = new WaveStream(sourceStream, destinationStream);
					if (audioStream.Length <= 0){
						throw new Exception("Invalid WAV file");
					}
				
					
					if(countSamplesRequired > audioStream.CountSamples){
						String errorReport = "The carrier file is too small for this message and key!\r\n"
							+ "Samples available: " + audioStream.CountSamples + "\r\n"			
							+ "Samples needed: " + countSamplesRequired;
						throw new Exception(errorReport);
					}

					
					WaveUtility utility = new WaveUtility(audioStream, destinationStream);
					utility.Hide(messageStream, keyStream);
				}
				catch(Exception ex) 
                {
					this.Cursor = Cursors.Default;
					MessageBox.Show(ex.Message);
				}
				finally{
					if(keyStream != null){ keyStream.Close(); }
					if(messageStream != null){ messageStream.Close(); }
					if(audioStream != null){ audioStream.Close(); }
					if(sourceStream != null){ sourceStream.Close(); }
					if(destinationStream != null){ destinationStream.Close(); }
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void btnExtract_Click(object sender, System.EventArgs e) {
			
			
			if(txtSrcFile.Text.Length == 0){
				errorProvider.SetError(txtSrcFile, "You forgot to choose a carrier file.");
			}
			else if(txtKeyFile.Text.Length == 0){
				errorProvider.SetError(txtKeyFile, "You forgot to choose a key file.");
			}
			else{

				this.Cursor = Cursors.WaitCursor;
			
				FileStream sourceStream = null;
				WaveStream audioStream = null;
				
				MemoryStream messageStream = new MemoryStream();
				
				Stream keyStream = new FileStream(txtKeyFile.Text, FileMode.Open);
			
				try {
					
					sourceStream = new FileStream(txtSrcFile.Text, FileMode.Open);
					audioStream = new WaveStream(sourceStream);
					WaveUtility utility = new WaveUtility(audioStream);
			
					
					utility.Extract(messageStream, keyStream);
				
					messageStream.Seek(0, SeekOrigin.Begin);
					if(rdoMessageDstFile.Checked){ //save result to a file
						FileStream fs = new FileStream(txtMessageDstFile.Text, FileMode.Create);
						
						byte[] buffer = new byte[messageStream.Length];
						messageStream.Read(buffer, 0, buffer.Length);
						fs.Write(buffer, 0, buffer.Length);
						fs.Close();
					}
                    else
                    { 
						txtExtractedMessage.Text = new StreamReader(messageStream).ReadToEnd();					
					}
				}
				catch(Exception ex) {
					this.Cursor = Cursors.Default;
					MessageBox.Show(ex.Message);
				}
				finally{
					if(keyStream != null){ keyStream.Close(); }
					if(messageStream != null){ messageStream.Close(); }
					if(audioStream != null){ audioStream.Close(); }
					if(sourceStream != null){ sourceStream.Close(); }
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void tabCtl_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(tabCtl.SelectedIndex==0)
            {				
            }
            else
            {	
                
				rdoSrcFile.Checked = true;
								
			}
		}

			private void GetFileName(FileDialog dialog, TextBox control, bool useFilter)
            {
			if(useFilter)
            {
                dialog.Filter = "Wave Audio (*.wav)|*.wav"; 
            }
			if( dialog.ShowDialog(this) == DialogResult.OK){
				control.Text = dialog.FileName;
			}
		}

			private Stream GetMessageStream(){
			BinaryWriter messageWriter = new BinaryWriter(new MemoryStream());
			if(rdoMsgFile.Checked){
				FileStream fs = new FileStream(txtMsgFile.Text, FileMode.Open);
				int fileLength = (int)fs.Length;
				messageWriter.Write(fileLength);
				byte[] buffer = new byte[fs.Length];
				fs.Read(buffer, 0, fileLength);
				messageWriter.Write(buffer);
				fs.Close();
			}else{
				messageWriter.Write(txtMessage.Text.Length);
				messageWriter.Write(Encoding.ASCII.GetBytes(txtMessage.Text));
			}
			messageWriter.Seek(0, SeekOrigin.Begin);
			return messageWriter.BaseStream;			
		}

		private void rdoCarrierWave_CheckedChanged(object sender, System.EventArgs e) {
			txtSrcFile.Enabled = btnSrcFile.Enabled = rdoSrcFile.Checked;
		}

		private void rdoContent_CheckedChanged(object sender, System.EventArgs e) {
			txtMsgFile.Enabled = btnMsgFile1.Enabled = rdoMsgFile.Checked;
			txtMessage.Enabled = rdoMsgText.Checked;
		}

		private void textField_TextChanged(object sender, System.EventArgs e) {
			errorProvider.SetError((Control)sender, String.Empty);
		}

		private void txtMsgFile_Enter(object sender, System.EventArgs e) {
			rdoMsgFile.Checked = true;
		}

		private void txtMessage_Enter(object sender, System.EventArgs e) {
			rdoMsgText.Checked = true;
		}

		private void txtMessageDstFile_Enter(object sender, System.EventArgs e) {
			rdoMessageDstFile.Checked = true;
		}

		private void txtExtractedMessage_Enter(object sender, System.EventArgs e) {
			rdoMessageDisplay.Checked = true;
		}

        private void rdoMessageDstFile_CheckedChanged(object sender, EventArgs e)
        {

        }

	}
}
