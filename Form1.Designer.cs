﻿namespace FuntionGraph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_funtion = new System.Windows.Forms.TextBox();
            this.btn_add_funtion = new System.Windows.Forms.Button();
            this.list_funtions = new System.Windows.Forms.ListBox();
            this.remove_selet = new System.Windows.Forms.Button();
            this.remove_all = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(800, 450);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tb_funtion);
            this.flowLayoutPanel1.Controls.Add(this.btn_add_funtion);
            this.flowLayoutPanel1.Controls.Add(this.list_funtions);
            this.flowLayoutPanel1.Controls.Add(this.remove_selet);
            this.flowLayoutPanel1.Controls.Add(this.remove_all);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(181, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adicione uma função";
            // 
            // tb_funtion
            // 
            this.tb_funtion.Location = new System.Drawing.Point(3, 16);
            this.tb_funtion.Name = "tb_funtion";
            this.tb_funtion.Size = new System.Drawing.Size(178, 20);
            this.tb_funtion.TabIndex = 0;
            // 
            // btn_add_funtion
            // 
            this.btn_add_funtion.Location = new System.Drawing.Point(3, 42);
            this.btn_add_funtion.Name = "btn_add_funtion";
            this.btn_add_funtion.Size = new System.Drawing.Size(178, 23);
            this.btn_add_funtion.TabIndex = 1;
            this.btn_add_funtion.Text = "Adicionar";
            this.btn_add_funtion.UseVisualStyleBackColor = true;
            this.btn_add_funtion.Click += new System.EventHandler(this.btn_add_funtion_Click);
            // 
            // list_funtions
            // 
            this.list_funtions.FormattingEnabled = true;
            this.list_funtions.Location = new System.Drawing.Point(3, 71);
            this.list_funtions.Name = "list_funtions";
            this.list_funtions.Size = new System.Drawing.Size(167, 316);
            this.list_funtions.TabIndex = 3;
            // 
            // remove_selet
            // 
            this.remove_selet.Location = new System.Drawing.Point(3, 393);
            this.remove_selet.Name = "remove_selet";
            this.remove_selet.Size = new System.Drawing.Size(178, 23);
            this.remove_selet.TabIndex = 4;
            this.remove_selet.Text = "Remover";
            this.remove_selet.UseVisualStyleBackColor = true;
            this.remove_selet.Click += new System.EventHandler(this.remove_selet_Click);
            // 
            // remove_all
            // 
            this.remove_all.Location = new System.Drawing.Point(3, 422);
            this.remove_all.Name = "remove_all";
            this.remove_all.Size = new System.Drawing.Size(178, 23);
            this.remove_all.TabIndex = 5;
            this.remove_all.Text = "Remover Tudo";
            this.remove_all.UseVisualStyleBackColor = true;
            this.remove_all.Click += new System.EventHandler(this.remove_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form1";
            this.Text = "Função Grafico";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_funtion;
        private System.Windows.Forms.Button btn_add_funtion;
        private System.Windows.Forms.ListBox list_funtions;
        private System.Windows.Forms.Button remove_selet;
        private System.Windows.Forms.Button remove_all;
    }
}

