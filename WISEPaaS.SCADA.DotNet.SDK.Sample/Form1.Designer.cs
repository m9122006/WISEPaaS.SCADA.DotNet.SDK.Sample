﻿namespace WISEPaaS.SCADA.DotNet.SDK.Sample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDeleteTags = new System.Windows.Forms.Button();
            this.btnDeleteDevices = new System.Windows.Forms.Button();
            this.btnDeleteAllConfig = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnUpdateConfig = new System.Windows.Forms.Button();
            this.ckbSecure = new System.Windows.Forms.CheckBox();
            this.btnDeviceStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.numATagCount = new System.Windows.Forms.NumericUpDown();
            this.btnSendData = new System.Windows.Forms.Button();
            this.lblATagCount = new System.Windows.Forms.Label();
            this.numDeviceCount = new System.Windows.Forms.NumericUpDown();
            this.lblDeviceCount = new System.Windows.Forms.Label();
            this.btnUploadConfig = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDCCSKey = new System.Windows.Forms.Label();
            this.txtDCCSKey = new System.Windows.Forms.TextBox();
            this.lblDCCSAPIUrl = new System.Windows.Forms.Label();
            this.txtDCCSAPIUrl = new System.Windows.Forms.TextBox();
            this.txtScadaId = new System.Windows.Forms.TextBox();
            this.lblScadaId = new System.Windows.Forms.Label();
            this.numDTagCount = new System.Windows.Forms.NumericUpDown();
            this.lblDTagCount = new System.Windows.Forms.Label();
            this.numTTagCount = new System.Windows.Forms.NumericUpDown();
            this.lblTTagCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numATagCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDTagCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTTagCount)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDeleteTags
            // 
            this.btnDeleteTags.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteTags.Location = new System.Drawing.Point(661, 348);
            this.btnDeleteTags.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteTags.Name = "btnDeleteTags";
            this.btnDeleteTags.Size = new System.Drawing.Size(134, 69);
            this.btnDeleteTags.TabIndex = 26;
            this.btnDeleteTags.Text = "Delete Tags";
            this.btnDeleteTags.UseVisualStyleBackColor = true;
            this.btnDeleteTags.Click += new System.EventHandler(this.btnDeleteTags_Click);
            // 
            // btnDeleteDevices
            // 
            this.btnDeleteDevices.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteDevices.Location = new System.Drawing.Point(661, 269);
            this.btnDeleteDevices.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteDevices.Name = "btnDeleteDevices";
            this.btnDeleteDevices.Size = new System.Drawing.Size(134, 69);
            this.btnDeleteDevices.TabIndex = 25;
            this.btnDeleteDevices.Text = "Delete Devices";
            this.btnDeleteDevices.UseVisualStyleBackColor = true;
            this.btnDeleteDevices.Click += new System.EventHandler(this.btnDeleteDevices_Click);
            // 
            // btnDeleteAllConfig
            // 
            this.btnDeleteAllConfig.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteAllConfig.Location = new System.Drawing.Point(661, 190);
            this.btnDeleteAllConfig.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteAllConfig.Name = "btnDeleteAllConfig";
            this.btnDeleteAllConfig.Size = new System.Drawing.Size(134, 69);
            this.btnDeleteAllConfig.TabIndex = 24;
            this.btnDeleteAllConfig.Text = "Delete All Config";
            this.btnDeleteAllConfig.UseVisualStyleBackColor = true;
            this.btnDeleteAllConfig.Click += new System.EventHandler(this.btnDeleteAllConfig_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnect.Location = new System.Drawing.Point(508, 147);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(134, 69);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateConfig.Location = new System.Drawing.Point(661, 109);
            this.btnUpdateConfig.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(134, 69);
            this.btnUpdateConfig.TabIndex = 23;
            this.btnUpdateConfig.Text = "Update Config";
            this.btnUpdateConfig.UseVisualStyleBackColor = true;
            this.btnUpdateConfig.Click += new System.EventHandler(this.btnUpdateConfig_Click);
            // 
            // ckbSecure
            // 
            this.ckbSecure.AutoSize = true;
            this.ckbSecure.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbSecure.Location = new System.Drawing.Point(16, 204);
            this.ckbSecure.Margin = new System.Windows.Forms.Padding(4);
            this.ckbSecure.Name = "ckbSecure";
            this.ckbSecure.Size = new System.Drawing.Size(79, 24);
            this.ckbSecure.TabIndex = 22;
            this.ckbSecure.Text = "Secure";
            this.ckbSecure.UseVisualStyleBackColor = true;
            // 
            // btnDeviceStatus
            // 
            this.btnDeviceStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeviceStatus.Location = new System.Drawing.Point(364, 238);
            this.btnDeviceStatus.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeviceStatus.Name = "btnDeviceStatus";
            this.btnDeviceStatus.Size = new System.Drawing.Size(134, 69);
            this.btnDeviceStatus.TabIndex = 22;
            this.btnDeviceStatus.Text = "Update Device Status";
            this.btnDeviceStatus.UseVisualStyleBackColor = true;
            this.btnDeviceStatus.Click += new System.EventHandler(this.btnDeviceStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Gray;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.Location = new System.Drawing.Point(443, 27);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(199, 100);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "DISCONNECTED";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numATagCount
            // 
            this.numATagCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numATagCount.Location = new System.Drawing.Point(188, 278);
            this.numATagCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numATagCount.Name = "numATagCount";
            this.numATagCount.Size = new System.Drawing.Size(120, 29);
            this.numATagCount.TabIndex = 19;
            this.numATagCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnSendData
            // 
            this.btnSendData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendData.Location = new System.Drawing.Point(508, 238);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(134, 69);
            this.btnSendData.TabIndex = 21;
            this.btnSendData.Text = "Send Data in Loop";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // lblATagCount
            // 
            this.lblATagCount.AutoSize = true;
            this.lblATagCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblATagCount.Location = new System.Drawing.Point(185, 255);
            this.lblATagCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblATagCount.Name = "lblATagCount";
            this.lblATagCount.Size = new System.Drawing.Size(146, 20);
            this.lblATagCount.TabIndex = 18;
            this.lblATagCount.Text = "Analog Tag Count";
            // 
            // numDeviceCount
            // 
            this.numDeviceCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numDeviceCount.Location = new System.Drawing.Point(16, 278);
            this.numDeviceCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDeviceCount.Name = "numDeviceCount";
            this.numDeviceCount.Size = new System.Drawing.Size(120, 29);
            this.numDeviceCount.TabIndex = 17;
            this.numDeviceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDeviceCount
            // 
            this.lblDeviceCount.AutoSize = true;
            this.lblDeviceCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeviceCount.Location = new System.Drawing.Point(13, 255);
            this.lblDeviceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceCount.Name = "lblDeviceCount";
            this.lblDeviceCount.Size = new System.Drawing.Size(110, 20);
            this.lblDeviceCount.TabIndex = 16;
            this.lblDeviceCount.Text = "Device Count";
            // 
            // btnUploadConfig
            // 
            this.btnUploadConfig.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUploadConfig.Location = new System.Drawing.Point(661, 27);
            this.btnUploadConfig.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadConfig.Name = "btnUploadConfig";
            this.btnUploadConfig.Size = new System.Drawing.Size(134, 69);
            this.btnUploadConfig.TabIndex = 20;
            this.btnUploadConfig.Text = "Upload Config";
            this.btnUploadConfig.UseVisualStyleBackColor = true;
            this.btnUploadConfig.Click += new System.EventHandler(this.btnUploadConfig_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Location = new System.Drawing.Point(364, 147);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(134, 69);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numTTagCount);
            this.groupBox2.Controls.Add(this.lblTTagCount);
            this.groupBox2.Controls.Add(this.numDTagCount);
            this.groupBox2.Controls.Add(this.lblDTagCount);
            this.groupBox2.Controls.Add(this.lblDCCSKey);
            this.groupBox2.Controls.Add(this.txtDCCSKey);
            this.groupBox2.Controls.Add(this.lblDCCSAPIUrl);
            this.groupBox2.Controls.Add(this.txtDCCSAPIUrl);
            this.groupBox2.Controls.Add(this.btnDeleteTags);
            this.groupBox2.Controls.Add(this.btnDeleteDevices);
            this.groupBox2.Controls.Add(this.btnDeleteAllConfig);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.btnUpdateConfig);
            this.groupBox2.Controls.Add(this.ckbSecure);
            this.groupBox2.Controls.Add(this.btnDeviceStatus);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.numATagCount);
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Controls.Add(this.lblATagCount);
            this.groupBox2.Controls.Add(this.numDeviceCount);
            this.groupBox2.Controls.Add(this.lblDeviceCount);
            this.groupBox2.Controls.Add(this.btnUploadConfig);
            this.groupBox2.Controls.Add(this.txtScadaId);
            this.groupBox2.Controls.Add(this.lblScadaId);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 443);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // lblDCCSKey
            // 
            this.lblDCCSKey.AutoSize = true;
            this.lblDCCSKey.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDCCSKey.Location = new System.Drawing.Point(12, 86);
            this.lblDCCSKey.Name = "lblDCCSKey";
            this.lblDCCSKey.Size = new System.Drawing.Size(118, 20);
            this.lblDCCSKey.TabIndex = 37;
            this.lblDCCSKey.Text = "Credential Key";
            // 
            // txtDCCSKey
            // 
            this.txtDCCSKey.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDCCSKey.Location = new System.Drawing.Point(16, 109);
            this.txtDCCSKey.Name = "txtDCCSKey";
            this.txtDCCSKey.Size = new System.Drawing.Size(307, 29);
            this.txtDCCSKey.TabIndex = 38;
            // 
            // lblDCCSAPIUrl
            // 
            this.lblDCCSAPIUrl.AutoSize = true;
            this.lblDCCSAPIUrl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDCCSAPIUrl.Location = new System.Drawing.Point(13, 145);
            this.lblDCCSAPIUrl.Name = "lblDCCSAPIUrl";
            this.lblDCCSAPIUrl.Size = new System.Drawing.Size(61, 20);
            this.lblDCCSAPIUrl.TabIndex = 39;
            this.lblDCCSAPIUrl.Text = "API Url";
            // 
            // txtDCCSAPIUrl
            // 
            this.txtDCCSAPIUrl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDCCSAPIUrl.Location = new System.Drawing.Point(14, 168);
            this.txtDCCSAPIUrl.Name = "txtDCCSAPIUrl";
            this.txtDCCSAPIUrl.Size = new System.Drawing.Size(308, 29);
            this.txtDCCSAPIUrl.TabIndex = 40;
            // 
            // txtScadaId
            // 
            this.txtScadaId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScadaId.Location = new System.Drawing.Point(14, 51);
            this.txtScadaId.Margin = new System.Windows.Forms.Padding(4);
            this.txtScadaId.Name = "txtScadaId";
            this.txtScadaId.Size = new System.Drawing.Size(309, 29);
            this.txtScadaId.TabIndex = 15;
            // 
            // lblScadaId
            // 
            this.lblScadaId.AutoSize = true;
            this.lblScadaId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScadaId.Location = new System.Drawing.Point(13, 27);
            this.lblScadaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScadaId.Name = "lblScadaId";
            this.lblScadaId.Size = new System.Drawing.Size(84, 20);
            this.lblScadaId.TabIndex = 14;
            this.lblScadaId.Text = "SCADA ID";
            // 
            // numDTagCount
            // 
            this.numDTagCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numDTagCount.Location = new System.Drawing.Point(188, 333);
            this.numDTagCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDTagCount.Name = "numDTagCount";
            this.numDTagCount.Size = new System.Drawing.Size(120, 29);
            this.numDTagCount.TabIndex = 42;
            this.numDTagCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDTagCount
            // 
            this.lblDTagCount.AutoSize = true;
            this.lblDTagCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDTagCount.Location = new System.Drawing.Point(185, 310);
            this.lblDTagCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTagCount.Name = "lblDTagCount";
            this.lblDTagCount.Size = new System.Drawing.Size(153, 20);
            this.lblDTagCount.TabIndex = 41;
            this.lblDTagCount.Text = "Discrete Tag Count";
            // 
            // numTTagCount
            // 
            this.numTTagCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numTTagCount.Location = new System.Drawing.Point(188, 388);
            this.numTTagCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numTTagCount.Name = "numTTagCount";
            this.numTTagCount.Size = new System.Drawing.Size(120, 29);
            this.numTTagCount.TabIndex = 44;
            this.numTTagCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblTTagCount
            // 
            this.lblTTagCount.AutoSize = true;
            this.lblTTagCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTTagCount.Location = new System.Drawing.Point(185, 365);
            this.lblTTagCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTTagCount.Name = "lblTTagCount";
            this.lblTTagCount.Size = new System.Drawing.Size(124, 20);
            this.lblTTagCount.TabIndex = 43;
            this.lblTTagCount.Text = "Text Tag Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numATagCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDTagCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTTagCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDeleteTags;
        private System.Windows.Forms.Button btnDeleteDevices;
        private System.Windows.Forms.Button btnDeleteAllConfig;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnUpdateConfig;
        private System.Windows.Forms.CheckBox ckbSecure;
        private System.Windows.Forms.Button btnDeviceStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numATagCount;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label lblATagCount;
        private System.Windows.Forms.NumericUpDown numDeviceCount;
        private System.Windows.Forms.Label lblDeviceCount;
        private System.Windows.Forms.Button btnUploadConfig;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDCCSKey;
        private System.Windows.Forms.TextBox txtDCCSKey;
        private System.Windows.Forms.Label lblDCCSAPIUrl;
        private System.Windows.Forms.TextBox txtDCCSAPIUrl;
        private System.Windows.Forms.NumericUpDown numTTagCount;
        private System.Windows.Forms.Label lblTTagCount;
        private System.Windows.Forms.NumericUpDown numDTagCount;
        private System.Windows.Forms.Label lblDTagCount;
        private System.Windows.Forms.TextBox txtScadaId;
        private System.Windows.Forms.Label lblScadaId;
    }
}

