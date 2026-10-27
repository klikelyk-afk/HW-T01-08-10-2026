namespace WinFormsApp_DNS_511
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGetIp = new Button();
            textBoxHostName = new TextBox();
            textBoxIpAddress = new TextBox();
            buttonGetHost = new Button();
            listBoxAddresses = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelHostName = new Label();
            button1 = new Button();
            buttonRemoveIp = new Button();
            buttonPingSelected = new Button();
            buttonAddIp = new Button();
            listBoxPingResult = new ListBox();
            label4 = new Label();
            textBoxNewIp = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonGetIp
            // 
            buttonGetIp.Location = new Point(183, 28);
            buttonGetIp.Margin = new Padding(3, 2, 3, 2);
            buttonGetIp.Name = "buttonGetIp";
            buttonGetIp.Size = new Size(82, 22);
            buttonGetIp.TabIndex = 0;
            buttonGetIp.Text = "Get IP";
            buttonGetIp.UseVisualStyleBackColor = true;
            buttonGetIp.Click += buttonGetIp_Click;
            // 
            // textBoxHostName
            // 
            textBoxHostName.Location = new Point(20, 29);
            textBoxHostName.Margin = new Padding(3, 2, 3, 2);
            textBoxHostName.Name = "textBoxHostName";
            textBoxHostName.Size = new Size(146, 23);
            textBoxHostName.TabIndex = 1;
            // 
            // textBoxIpAddress
            // 
            textBoxIpAddress.Location = new Point(20, 308);
            textBoxIpAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxIpAddress.Name = "textBoxIpAddress";
            textBoxIpAddress.Size = new Size(146, 23);
            textBoxIpAddress.TabIndex = 2;
            // 
            // buttonGetHost
            // 
            buttonGetHost.Location = new Point(183, 308);
            buttonGetHost.Margin = new Padding(3, 2, 3, 2);
            buttonGetHost.Name = "buttonGetHost";
            buttonGetHost.Size = new Size(82, 22);
            buttonGetHost.TabIndex = 3;
            buttonGetHost.Text = "Get Host";
            buttonGetHost.UseVisualStyleBackColor = true;
            buttonGetHost.Click += buttonGetHost_Click;
            // 
            // listBoxAddresses
            // 
            listBoxAddresses.FormattingEnabled = true;
            listBoxAddresses.Location = new Point(20, 83);
            listBoxAddresses.Margin = new Padding(3, 2, 3, 2);
            listBoxAddresses.Name = "listBoxAddresses";
            listBoxAddresses.Size = new Size(146, 199);
            listBoxAddresses.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Host:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 291);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "IP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 66);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 7;
            label3.Text = "IP addresses:";
            // 
            // labelHostName
            // 
            labelHostName.AutoSize = true;
            labelHostName.Location = new Point(286, 311);
            labelHostName.Name = "labelHostName";
            labelHostName.Size = new Size(81, 15);
            labelHostName.TabIndex = 8;
            labelHostName.Text = "<host_name>";
            // 
            // button1
            // 
            button1.Location = new Point(291, 29);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(163, 22);
            button1.TabIndex = 9;
            button1.Text = "Ping host with steps";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonRemoveIp
            // 
            buttonRemoveIp.Location = new Point(183, 141);
            buttonRemoveIp.Name = "buttonRemoveIp";
            buttonRemoveIp.Size = new Size(82, 23);
            buttonRemoveIp.TabIndex = 10;
            buttonRemoveIp.Text = "Remove";
            buttonRemoveIp.UseVisualStyleBackColor = true;
            buttonRemoveIp.Click += buttonRemove_Click;
            // 
            // buttonPingSelected
            // 
            buttonPingSelected.Location = new Point(183, 170);
            buttonPingSelected.Name = "buttonPingSelected";
            buttonPingSelected.Size = new Size(82, 23);
            buttonPingSelected.TabIndex = 11;
            buttonPingSelected.Text = "Ping";
            buttonPingSelected.UseVisualStyleBackColor = true;
            buttonPingSelected.Click += buttonPing_Click;
            // 
            // buttonAddIp
            // 
            buttonAddIp.Location = new Point(183, 112);
            buttonAddIp.Name = "buttonAddIp";
            buttonAddIp.Size = new Size(82, 23);
            buttonAddIp.TabIndex = 12;
            buttonAddIp.Text = "Add";
            buttonAddIp.UseVisualStyleBackColor = true;
            buttonAddIp.Click += buttonAdd_Click;
            // 
            // listBoxPingResult
            // 
            listBoxPingResult.FormattingEnabled = true;
            listBoxPingResult.Location = new Point(291, 83);
            listBoxPingResult.Name = "listBoxPingResult";
            listBoxPingResult.Size = new Size(369, 199);
            listBoxPingResult.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 63);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 14;
            label4.Text = "Ping result:";
            // 
            // textBoxNewIp
            // 
            textBoxNewIp.Location = new Point(183, 83);
            textBoxNewIp.Name = "textBoxNewIp";
            textBoxNewIp.Size = new Size(82, 23);
            textBoxNewIp.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 63);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 17;
            label6.Text = "New IP:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxNewIp);
            Controls.Add(label4);
            Controls.Add(listBoxPingResult);
            Controls.Add(buttonAddIp);
            Controls.Add(buttonPingSelected);
            Controls.Add(buttonRemoveIp);
            Controls.Add(button1);
            Controls.Add(labelHostName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxAddresses);
            Controls.Add(buttonGetHost);
            Controls.Add(textBoxIpAddress);
            Controls.Add(textBoxHostName);
            Controls.Add(buttonGetIp);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetIp;
        private TextBox textBoxHostName;
        private TextBox textBoxIpAddress;
        private Button buttonGetHost;
        private ListBox listBoxAddresses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelHostName;
        private Button button1;
        private Button buttonRemoveIp;
        private Button buttonPingSelected;
        private Button buttonAddIp;
        private ListBox listBoxPingResult;
        private Label label4;
        private TextBox textBoxNewIp;
        private Label label5;
        private Label label6;
    }
}
