
namespace EzCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sumkr = new System.Windows.Forms.TextBox();
            this.prstavka = new System.Windows.Forms.TextBox();
            this.srokvgo = new System.Windows.Forms.TextBox();
            this.srokvme = new System.Windows.Forms.TextBox();
            this.viplatavme = new System.Windows.Forms.TextBox();
            this.Summaviplat = new System.Windows.Forms.TextBox();
            this.Summaperepla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Простой кредитный калькулятор";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма кредита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Процентная ставка, %";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Срок в годах, г.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Срок в месяцах";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выплата в месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Сумма переплаты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Общая сумма выплат ";
            // 
            // sumkr
            // 
            this.sumkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumkr.Location = new System.Drawing.Point(223, 84);
            this.sumkr.Name = "sumkr";
            this.sumkr.Size = new System.Drawing.Size(173, 26);
            this.sumkr.TabIndex = 2;
            // 
            // prstavka
            // 
            this.prstavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prstavka.Location = new System.Drawing.Point(223, 115);
            this.prstavka.Name = "prstavka";
            this.prstavka.Size = new System.Drawing.Size(173, 26);
            this.prstavka.TabIndex = 3;
            // 
            // srokvgo
            // 
            this.srokvgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srokvgo.Location = new System.Drawing.Point(223, 145);
            this.srokvgo.Name = "srokvgo";
            this.srokvgo.Size = new System.Drawing.Size(173, 26);
            this.srokvgo.TabIndex = 4;
            // 
            // srokvme
            // 
            this.srokvme.Location = new System.Drawing.Point(223, 332);
            this.srokvme.Name = "srokvme";
            this.srokvme.ReadOnly = true;
            this.srokvme.Size = new System.Drawing.Size(173, 20);
            this.srokvme.TabIndex = 4;
            // 
            // viplatavme
            // 
            this.viplatavme.Location = new System.Drawing.Point(223, 358);
            this.viplatavme.Name = "viplatavme";
            this.viplatavme.ReadOnly = true;
            this.viplatavme.Size = new System.Drawing.Size(173, 20);
            this.viplatavme.TabIndex = 4;
            // 
            // Summaviplat
            // 
            this.Summaviplat.Location = new System.Drawing.Point(223, 384);
            this.Summaviplat.Name = "Summaviplat";
            this.Summaviplat.ReadOnly = true;
            this.Summaviplat.Size = new System.Drawing.Size(173, 20);
            this.Summaviplat.TabIndex = 4;
            // 
            // Summaperepla
            // 
            this.Summaperepla.Location = new System.Drawing.Point(223, 410);
            this.Summaperepla.Name = "Summaperepla";
            this.Summaperepla.ReadOnly = true;
            this.Summaperepla.Size = new System.Drawing.Size(173, 20);
            this.Summaperepla.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(223, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.Payment,
            this.Procents,
            this.AllPayment,
            this.NeedToPay});
            this.dataGridView1.Location = new System.Drawing.Point(481, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 361);
            this.dataGridView1.TabIndex = 6;
            // 
            // Period
            // 
            this.Period.HeaderText = "Период";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Выплата кредита";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // Procents
            // 
            this.Procents.HeaderText = "Выплата процентов";
            this.Procents.Name = "Procents";
            this.Procents.ReadOnly = true;
            // 
            // AllPayment
            // 
            this.AllPayment.HeaderText = "Общая выплата";
            this.AllPayment.Name = "AllPayment";
            this.AllPayment.ReadOnly = true;
            // 
            // NeedToPay
            // 
            this.NeedToPay.HeaderText = "Осталось выплатить";
            this.NeedToPay.Name = "NeedToPay";
            this.NeedToPay.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(49, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Занесите свои данные";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(50, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Расчеты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1090, 509);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Summaperepla);
            this.Controls.Add(this.Summaviplat);
            this.Controls.Add(this.viplatavme);
            this.Controls.Add(this.srokvme);
            this.Controls.Add(this.srokvgo);
            this.Controls.Add(this.prstavka);
            this.Controls.Add(this.sumkr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Простой кредитный калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sumkr;
        private System.Windows.Forms.TextBox prstavka;
        private System.Windows.Forms.TextBox srokvgo;
        private System.Windows.Forms.TextBox srokvme;
        private System.Windows.Forms.TextBox viplatavme;
        private System.Windows.Forms.TextBox Summaviplat;
        private System.Windows.Forms.TextBox Summaperepla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procents;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedToPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

