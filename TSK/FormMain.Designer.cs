namespace TSK
{
    partial class FormMain
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
            this.numericUpDownCoefficient = new System.Windows.Forms.NumericUpDown();
            this.groupBoxNetworkParameters = new System.Windows.Forms.GroupBox();
            this.buttonInitialize = new System.Windows.Forms.Button();
            this.labelCoefficient = new System.Windows.Forms.Label();
            this.groupBoxTestNetwork = new System.Windows.Forms.GroupBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxTestResult = new System.Windows.Forms.TextBox();
            this.labelTestResult = new System.Windows.Forms.Label();
            this.labelFirstParameter = new System.Windows.Forms.Label();
            this.numericUpDownSixthParameter = new System.Windows.Forms.NumericUpDown();
            this.labelFifthParameter = new System.Windows.Forms.Label();
            this.numericUpDownFifthParameter = new System.Windows.Forms.NumericUpDown();
            this.labelSecondParameter = new System.Windows.Forms.Label();
            this.numericUpDownFirstParameter = new System.Windows.Forms.NumericUpDown();
            this.labelSixthParameter = new System.Windows.Forms.Label();
            this.numericUpDownSecondParameter = new System.Windows.Forms.NumericUpDown();
            this.labelFourthParameter = new System.Windows.Forms.Label();
            this.numericUpDownFourthParameter = new System.Windows.Forms.NumericUpDown();
            this.labelThirdParameter = new System.Windows.Forms.Label();
            this.numericUpDownThirdParameter = new System.Windows.Forms.NumericUpDown();
            this.groupBoxLearning = new System.Windows.Forms.GroupBox();
            this.buttonStopLearning = new System.Windows.Forms.Button();
            this.buttonStartLearning = new System.Windows.Forms.Button();
            this.textBoxLearningError = new System.Windows.Forms.TextBox();
            this.labelLearningError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoefficient)).BeginInit();
            this.groupBoxNetworkParameters.SuspendLayout();
            this.groupBoxTestNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSixthParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFifthParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFourthParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThirdParameter)).BeginInit();
            this.groupBoxLearning.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownCoefficient
            // 
            this.numericUpDownCoefficient.DecimalPlaces = 3;
            this.numericUpDownCoefficient.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownCoefficient.Location = new System.Drawing.Point(138, 29);
            this.numericUpDownCoefficient.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            196608});
            this.numericUpDownCoefficient.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownCoefficient.Name = "numericUpDownCoefficient";
            this.numericUpDownCoefficient.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownCoefficient.TabIndex = 0;
            this.numericUpDownCoefficient.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // groupBoxNetworkParameters
            // 
            this.groupBoxNetworkParameters.Controls.Add(this.buttonInitialize);
            this.groupBoxNetworkParameters.Controls.Add(this.labelCoefficient);
            this.groupBoxNetworkParameters.Controls.Add(this.numericUpDownCoefficient);
            this.groupBoxNetworkParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNetworkParameters.Name = "groupBoxNetworkParameters";
            this.groupBoxNetworkParameters.Size = new System.Drawing.Size(200, 113);
            this.groupBoxNetworkParameters.TabIndex = 1;
            this.groupBoxNetworkParameters.TabStop = false;
            this.groupBoxNetworkParameters.Text = "Параметры сети";
            // 
            // buttonInitialize
            // 
            this.buttonInitialize.Location = new System.Drawing.Point(9, 84);
            this.buttonInitialize.Name = "buttonInitialize";
            this.buttonInitialize.Size = new System.Drawing.Size(185, 23);
            this.buttonInitialize.TabIndex = 13;
            this.buttonInitialize.Text = "Инициализация сети";
            this.buttonInitialize.UseVisualStyleBackColor = true;
            this.buttonInitialize.Click += new System.EventHandler(this.buttonInitialize_Click);
            // 
            // labelCoefficient
            // 
            this.labelCoefficient.AutoSize = true;
            this.labelCoefficient.Location = new System.Drawing.Point(6, 31);
            this.labelCoefficient.Name = "labelCoefficient";
            this.labelCoefficient.Size = new System.Drawing.Size(126, 13);
            this.labelCoefficient.TabIndex = 2;
            this.labelCoefficient.Text = "Коэффициент обучения";
            // 
            // groupBoxTestNetwork
            // 
            this.groupBoxTestNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTestNetwork.Controls.Add(this.buttonTest);
            this.groupBoxTestNetwork.Controls.Add(this.textBoxTestResult);
            this.groupBoxTestNetwork.Controls.Add(this.labelTestResult);
            this.groupBoxTestNetwork.Controls.Add(this.labelFirstParameter);
            this.groupBoxTestNetwork.Controls.Add(this.numericUpDownSixthParameter);
            this.groupBoxTestNetwork.Controls.Add(this.labelFifthParameter);
            this.groupBoxTestNetwork.Controls.Add(this.numericUpDownFifthParameter);
            this.groupBoxTestNetwork.Controls.Add(this.labelSecondParameter);
            this.groupBoxTestNetwork.Controls.Add(this.numericUpDownFirstParameter);
            this.groupBoxTestNetwork.Controls.Add(this.labelSixthParameter);
            this.groupBoxTestNetwork.Controls.Add(this.numericUpDownSecondParameter);
            this.groupBoxTestNetwork.Controls.Add(this.labelFourthParameter);
            this.groupBoxTestNetwork.Controls.Add(this.numericUpDownFourthParameter);
            this.groupBoxTestNetwork.Controls.Add(this.labelThirdParameter);
            this.groupBoxTestNetwork.Controls.Add(this.numericUpDownThirdParameter);
            this.groupBoxTestNetwork.Location = new System.Drawing.Point(705, 12);
            this.groupBoxTestNetwork.Name = "groupBoxTestNetwork";
            this.groupBoxTestNetwork.Size = new System.Drawing.Size(200, 233);
            this.groupBoxTestNetwork.TabIndex = 3;
            this.groupBoxTestNetwork.TabStop = false;
            this.groupBoxTestNetwork.Text = "Тест сети";
            // 
            // buttonTest
            // 
            this.buttonTest.Enabled = false;
            this.buttonTest.Location = new System.Drawing.Point(9, 175);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(185, 23);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Вычисление";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxTestResult
            // 
            this.textBoxTestResult.Location = new System.Drawing.Point(77, 205);
            this.textBoxTestResult.Name = "textBoxTestResult";
            this.textBoxTestResult.ReadOnly = true;
            this.textBoxTestResult.Size = new System.Drawing.Size(117, 20);
            this.textBoxTestResult.TabIndex = 5;
            // 
            // labelTestResult
            // 
            this.labelTestResult.AutoSize = true;
            this.labelTestResult.Location = new System.Drawing.Point(6, 209);
            this.labelTestResult.Name = "labelTestResult";
            this.labelTestResult.Size = new System.Drawing.Size(65, 13);
            this.labelTestResult.TabIndex = 6;
            this.labelTestResult.Text = "Выход сети";
            // 
            // labelFirstParameter
            // 
            this.labelFirstParameter.AutoSize = true;
            this.labelFirstParameter.Location = new System.Drawing.Point(6, 17);
            this.labelFirstParameter.Name = "labelFirstParameter";
            this.labelFirstParameter.Size = new System.Drawing.Size(99, 13);
            this.labelFirstParameter.TabIndex = 12;
            this.labelFirstParameter.Text = "Первый параметр";
            // 
            // numericUpDownSixthParameter
            // 
            this.numericUpDownSixthParameter.DecimalPlaces = 3;
            this.numericUpDownSixthParameter.Location = new System.Drawing.Point(138, 145);
            this.numericUpDownSixthParameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownSixthParameter.Name = "numericUpDownSixthParameter";
            this.numericUpDownSixthParameter.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownSixthParameter.TabIndex = 11;
            this.numericUpDownSixthParameter.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // labelFifthParameter
            // 
            this.labelFifthParameter.AutoSize = true;
            this.labelFifthParameter.Location = new System.Drawing.Point(6, 121);
            this.labelFifthParameter.Name = "labelFifthParameter";
            this.labelFifthParameter.Size = new System.Drawing.Size(92, 13);
            this.labelFifthParameter.TabIndex = 10;
            this.labelFifthParameter.Text = "Пятый параметр";
            // 
            // numericUpDownFifthParameter
            // 
            this.numericUpDownFifthParameter.DecimalPlaces = 3;
            this.numericUpDownFifthParameter.Location = new System.Drawing.Point(138, 119);
            this.numericUpDownFifthParameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFifthParameter.Name = "numericUpDownFifthParameter";
            this.numericUpDownFifthParameter.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownFifthParameter.TabIndex = 9;
            this.numericUpDownFifthParameter.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // labelSecondParameter
            // 
            this.labelSecondParameter.AutoSize = true;
            this.labelSecondParameter.Location = new System.Drawing.Point(6, 43);
            this.labelSecondParameter.Name = "labelSecondParameter";
            this.labelSecondParameter.Size = new System.Drawing.Size(95, 13);
            this.labelSecondParameter.TabIndex = 8;
            this.labelSecondParameter.Text = "Второй параметр";
            // 
            // numericUpDownFirstParameter
            // 
            this.numericUpDownFirstParameter.DecimalPlaces = 3;
            this.numericUpDownFirstParameter.Location = new System.Drawing.Point(138, 15);
            this.numericUpDownFirstParameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFirstParameter.Name = "numericUpDownFirstParameter";
            this.numericUpDownFirstParameter.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownFirstParameter.TabIndex = 7;
            this.numericUpDownFirstParameter.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // labelSixthParameter
            // 
            this.labelSixthParameter.AutoSize = true;
            this.labelSixthParameter.Location = new System.Drawing.Point(6, 147);
            this.labelSixthParameter.Name = "labelSixthParameter";
            this.labelSixthParameter.Size = new System.Drawing.Size(97, 13);
            this.labelSixthParameter.TabIndex = 6;
            this.labelSixthParameter.Text = "Шестой параметр";
            // 
            // numericUpDownSecondParameter
            // 
            this.numericUpDownSecondParameter.DecimalPlaces = 3;
            this.numericUpDownSecondParameter.Location = new System.Drawing.Point(138, 41);
            this.numericUpDownSecondParameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownSecondParameter.Name = "numericUpDownSecondParameter";
            this.numericUpDownSecondParameter.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownSecondParameter.TabIndex = 5;
            this.numericUpDownSecondParameter.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // labelFourthParameter
            // 
            this.labelFourthParameter.AutoSize = true;
            this.labelFourthParameter.Location = new System.Drawing.Point(6, 95);
            this.labelFourthParameter.Name = "labelFourthParameter";
            this.labelFourthParameter.Size = new System.Drawing.Size(115, 13);
            this.labelFourthParameter.TabIndex = 4;
            this.labelFourthParameter.Text = "Четвертый параметр";
            // 
            // numericUpDownFourthParameter
            // 
            this.numericUpDownFourthParameter.DecimalPlaces = 3;
            this.numericUpDownFourthParameter.Location = new System.Drawing.Point(138, 93);
            this.numericUpDownFourthParameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFourthParameter.Name = "numericUpDownFourthParameter";
            this.numericUpDownFourthParameter.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownFourthParameter.TabIndex = 3;
            this.numericUpDownFourthParameter.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // labelThirdParameter
            // 
            this.labelThirdParameter.AutoSize = true;
            this.labelThirdParameter.Location = new System.Drawing.Point(6, 69);
            this.labelThirdParameter.Name = "labelThirdParameter";
            this.labelThirdParameter.Size = new System.Drawing.Size(95, 13);
            this.labelThirdParameter.TabIndex = 2;
            this.labelThirdParameter.Text = "Третий параметр";
            // 
            // numericUpDownThirdParameter
            // 
            this.numericUpDownThirdParameter.DecimalPlaces = 3;
            this.numericUpDownThirdParameter.Location = new System.Drawing.Point(138, 67);
            this.numericUpDownThirdParameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownThirdParameter.Name = "numericUpDownThirdParameter";
            this.numericUpDownThirdParameter.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownThirdParameter.TabIndex = 0;
            this.numericUpDownThirdParameter.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // groupBoxLearning
            // 
            this.groupBoxLearning.Controls.Add(this.buttonStopLearning);
            this.groupBoxLearning.Controls.Add(this.buttonStartLearning);
            this.groupBoxLearning.Controls.Add(this.textBoxLearningError);
            this.groupBoxLearning.Controls.Add(this.labelLearningError);
            this.groupBoxLearning.Location = new System.Drawing.Point(218, 12);
            this.groupBoxLearning.Name = "groupBoxLearning";
            this.groupBoxLearning.Size = new System.Drawing.Size(200, 113);
            this.groupBoxLearning.TabIndex = 3;
            this.groupBoxLearning.TabStop = false;
            this.groupBoxLearning.Text = "Обучение сети";
            // 
            // buttonStopLearning
            // 
            this.buttonStopLearning.Enabled = false;
            this.buttonStopLearning.Location = new System.Drawing.Point(9, 84);
            this.buttonStopLearning.Name = "buttonStopLearning";
            this.buttonStopLearning.Size = new System.Drawing.Size(185, 23);
            this.buttonStopLearning.TabIndex = 15;
            this.buttonStopLearning.Text = "Остановить обучение";
            this.buttonStopLearning.UseVisualStyleBackColor = true;
            this.buttonStopLearning.Click += new System.EventHandler(this.buttonStopLearning_Click);
            // 
            // buttonStartLearning
            // 
            this.buttonStartLearning.Enabled = false;
            this.buttonStartLearning.Location = new System.Drawing.Point(9, 55);
            this.buttonStartLearning.Name = "buttonStartLearning";
            this.buttonStartLearning.Size = new System.Drawing.Size(185, 23);
            this.buttonStartLearning.TabIndex = 14;
            this.buttonStartLearning.Text = "Начать обучение";
            this.buttonStartLearning.UseVisualStyleBackColor = true;
            this.buttonStartLearning.Click += new System.EventHandler(this.buttonStartLearning_Click);
            // 
            // textBoxLearningError
            // 
            this.textBoxLearningError.Location = new System.Drawing.Point(105, 29);
            this.textBoxLearningError.Name = "textBoxLearningError";
            this.textBoxLearningError.ReadOnly = true;
            this.textBoxLearningError.Size = new System.Drawing.Size(89, 20);
            this.textBoxLearningError.TabIndex = 13;
            // 
            // labelLearningError
            // 
            this.labelLearningError.AutoSize = true;
            this.labelLearningError.Location = new System.Drawing.Point(6, 31);
            this.labelLearningError.Name = "labelLearningError";
            this.labelLearningError.Size = new System.Drawing.Size(93, 13);
            this.labelLearningError.TabIndex = 2;
            this.labelLearningError.Text = "Текущая ошибка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 634);
            this.Controls.Add(this.groupBoxLearning);
            this.Controls.Add(this.groupBoxTestNetwork);
            this.Controls.Add(this.groupBoxNetworkParameters);
            this.Name = "FormMain";
            this.Text = "TSK";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoefficient)).EndInit();
            this.groupBoxNetworkParameters.ResumeLayout(false);
            this.groupBoxNetworkParameters.PerformLayout();
            this.groupBoxTestNetwork.ResumeLayout(false);
            this.groupBoxTestNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSixthParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFifthParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFourthParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThirdParameter)).EndInit();
            this.groupBoxLearning.ResumeLayout(false);
            this.groupBoxLearning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCoefficient;
        private System.Windows.Forms.GroupBox groupBoxNetworkParameters;
        private System.Windows.Forms.Label labelCoefficient;
        private System.Windows.Forms.GroupBox groupBoxTestNetwork;
        private System.Windows.Forms.Label labelThirdParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownThirdParameter;
        private System.Windows.Forms.Label labelFirstParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownSixthParameter;
        private System.Windows.Forms.Label labelFifthParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownFifthParameter;
        private System.Windows.Forms.Label labelSecondParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownFirstParameter;
        private System.Windows.Forms.Label labelSixthParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownSecondParameter;
        private System.Windows.Forms.Label labelFourthParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownFourthParameter;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxTestResult;
        private System.Windows.Forms.Label labelTestResult;
        private System.Windows.Forms.Button buttonInitialize;
        private System.Windows.Forms.GroupBox groupBoxLearning;
        private System.Windows.Forms.Label labelLearningError;
        private System.Windows.Forms.TextBox textBoxLearningError;
        private System.Windows.Forms.Button buttonStopLearning;
        private System.Windows.Forms.Button buttonStartLearning;
    }
}

