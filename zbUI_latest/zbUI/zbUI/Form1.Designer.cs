namespace zbUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uremail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.docmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.age_box = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.agebox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxDisp = new System.Windows.Forms.TextBox();
            this.save_prof = new System.Windows.Forms.Button();
            this.displayUnit = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.uremail);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.docmail);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.description);
            this.splitContainer1.Panel1.Controls.Add(this.age_box);
            this.splitContainer1.Panel1.Controls.Add(this.name_label);
            this.splitContainer1.Panel1.Controls.Add(this.agebox);
            this.splitContainer1.Panel1.Controls.Add(this.namebox);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.save_prof);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.displayUnit);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(899, 599);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // uremail
            // 
            this.uremail.Location = new System.Drawing.Point(109, 457);
            this.uremail.Margin = new System.Windows.Forms.Padding(2);
            this.uremail.Name = "uremail";
            this.uremail.Size = new System.Drawing.Size(197, 20);
            this.uremail.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Patient Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doctor e-mail";
            // 
            // docmail
            // 
            this.docmail.Location = new System.Drawing.Point(106, 484);
            this.docmail.Margin = new System.Windows.Forms.Padding(2);
            this.docmail.Name = "docmail";
            this.docmail.Size = new System.Drawing.Size(197, 20);
            this.docmail.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 97);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient Description";
            // 
            // description
            // 
            this.description.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.description.Location = new System.Drawing.Point(106, 363);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(197, 84);
            this.description.TabIndex = 1;
            // 
            // age_box
            // 
            this.age_box.AutoSize = true;
            this.age_box.Location = new System.Drawing.Point(12, 343);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(29, 13);
            this.age_box.TabIndex = 9;
            this.age_box.Text = "AGE";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(12, 318);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 8;
            this.name_label.Text = "NAME";
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(106, 336);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(66, 20);
            this.agebox.TabIndex = 7;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(106, 310);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(200, 20);
            this.namebox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBoxDisp);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 163);
            this.panel1.TabIndex = 4;
            // 
            // TextBoxDisp
            // 
            this.TextBoxDisp.Location = new System.Drawing.Point(3, 3);
            this.TextBoxDisp.Multiline = true;
            this.TextBoxDisp.Name = "TextBoxDisp";
            this.TextBoxDisp.Size = new System.Drawing.Size(353, 157);
            this.TextBoxDisp.TabIndex = 0;
            // 
            // save_prof
            // 
            this.save_prof.Location = new System.Drawing.Point(10, 418);
            this.save_prof.Name = "save_prof";
            this.save_prof.Size = new System.Drawing.Size(84, 28);
            this.save_prof.TabIndex = 0;
            this.save_prof.Text = "Save Profile  ";
            this.save_prof.UseVisualStyleBackColor = true;
            this.save_prof.Click += new System.EventHandler(this.save_prof_Click);
            // 
            // displayUnit
            // 
            this.displayUnit.Location = new System.Drawing.Point(10, 286);
            this.displayUnit.Margin = new System.Windows.Forms.Padding(2);
            this.displayUnit.Multiline = true;
            this.displayUnit.Name = "displayUnit";
            this.displayUnit.Size = new System.Drawing.Size(225, 302);
            this.displayUnit.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(487, 268);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 181);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 86);
            this.textBox2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 599);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "++Zigbee Health Vigilance System v 0.1++";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label age_box;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save_prof;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox TextBoxDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox displayUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox docmail;
        private System.Windows.Forms.TextBox uremail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

