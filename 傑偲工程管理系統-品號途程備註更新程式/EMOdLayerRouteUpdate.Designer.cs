namespace 傑偲工程管理系統_品號途程備註更新程式
{
    partial class EMOdLayerRouteUpdate
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFilePath = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.dgvLoadData = new System.Windows.Forms.DataGridView();
            this.lblLoadData = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTotalData = new System.Windows.Forms.Label();
            this.lblTotalSuccess = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFilePath.Location = new System.Drawing.Point(93, 6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(450, 29);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnOpenFilePath
            // 
            this.btnOpenFilePath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenFilePath.Location = new System.Drawing.Point(549, 5);
            this.btnOpenFilePath.Name = "btnOpenFilePath";
            this.btnOpenFilePath.Size = new System.Drawing.Size(90, 30);
            this.btnOpenFilePath.TabIndex = 1;
            this.btnOpenFilePath.Text = "載入Excel";
            this.btnOpenFilePath.UseVisualStyleBackColor = true;
            this.btnOpenFilePath.Click += new System.EventHandler(this.btnOpenFilePath_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFilePath.Location = new System.Drawing.Point(12, 9);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(89, 20);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "檔案路徑：";
            // 
            // dgvLoadData
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoadData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoadData.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLoadData.Location = new System.Drawing.Point(12, 71);
            this.dgvLoadData.Name = "dgvLoadData";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoadData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLoadData.RowTemplate.Height = 24;
            this.dgvLoadData.Size = new System.Drawing.Size(760, 220);
            this.dgvLoadData.TabIndex = 3;
            // 
            // lblLoadData
            // 
            this.lblLoadData.AutoSize = true;
            this.lblLoadData.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoadData.Location = new System.Drawing.Point(12, 48);
            this.lblLoadData.Name = "lblLoadData";
            this.lblLoadData.Size = new System.Drawing.Size(133, 19);
            this.lblLoadData.TabIndex = 4;
            this.lblLoadData.Text = "載入的Excel資料，";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(8, 312);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(84, 19);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "更新結果，";
            // 
            // lblTotalData
            // 
            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalData.Location = new System.Drawing.Point(134, 48);
            this.lblTotalData.Name = "lblTotalData";
            this.lblTotalData.Size = new System.Drawing.Size(64, 19);
            this.lblTotalData.TabIndex = 6;
            this.lblTotalData.Text = "共X筆。";
            // 
            // lblTotalSuccess
            // 
            this.lblTotalSuccess.AutoSize = true;
            this.lblTotalSuccess.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalSuccess.Location = new System.Drawing.Point(80, 312);
            this.lblTotalSuccess.Name = "lblTotalSuccess";
            this.lblTotalSuccess.Size = new System.Drawing.Size(94, 19);
            this.lblTotalSuccess.TabIndex = 7;
            this.lblTotalSuccess.Text = "共完成X筆。";
            // 
            // rtbResult
            // 
            this.rtbResult.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbResult.Location = new System.Drawing.Point(12, 334);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(760, 220);
            this.rtbResult.TabIndex = 8;
            this.rtbResult.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(683, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 62);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EMOdLayerRouteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblTotalSuccess);
            this.Controls.Add(this.lblTotalData);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLoadData);
            this.Controls.Add(this.dgvLoadData);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnOpenFilePath);
            this.MaximizeBox = false;
            this.Name = "EMOdLayerRouteUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "品號途程備註更新程式 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpenFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.DataGridView dgvLoadData;
        private System.Windows.Forms.Label lblLoadData;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTotalData;
        private System.Windows.Forms.Label lblTotalSuccess;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btnUpdate;
    }
}

