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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartLearning = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelNeuronsLogs = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxLinearWeights = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSecondLayerThirdNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFirstLayerThirdNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSecondLayerSecondNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFirstLayerSecondNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSecondLayerFirstNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFourthLayerFirstNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFirstLayerFirstNeuron = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanelThirdLayerNeuronsLog = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxThirdLayerSecondNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxThirdLayerFirstNeuron = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutputNeuronsLog = new System.Windows.Forms.RichTextBox();
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
            this.textBoxCurrentEpoch = new System.Windows.Forms.TextBox();
            this.labelCurrentEpoch = new System.Windows.Forms.Label();
            this.groupBoxNetworkParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxShowNeuronsLog = new System.Windows.Forms.CheckBox();
            this.buttonInitialize = new System.Windows.Forms.Button();
            this.labelCoefficient = new System.Windows.Forms.Label();
            this.numericUpDownCoefficient = new System.Windows.Forms.NumericUpDown();
            this.tabPageLearning = new System.Windows.Forms.TabPage();
            this.labelLearningPercent = new System.Windows.Forms.Label();
            this.numericUpDownLearningPercent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chartLearning)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tableLayoutPanelNeuronsLogs.SuspendLayout();
            this.tableLayoutPanelThirdLayerNeuronsLog.SuspendLayout();
            this.groupBoxTestNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSixthParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFifthParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFourthParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThirdParameter)).BeginInit();
            this.groupBoxLearning.SuspendLayout();
            this.groupBoxNetworkParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoefficient)).BeginInit();
            this.tabPageLearning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearningPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLearning
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLearning.ChartAreas.Add(chartArea2);
            this.chartLearning.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartLearning.Legends.Add(legend2);
            this.chartLearning.Location = new System.Drawing.Point(3, 3);
            this.chartLearning.Name = "chartLearning";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Ошибка эпохи";
            this.chartLearning.Series.Add(series2);
            this.chartLearning.Size = new System.Drawing.Size(1028, 725);
            this.chartLearning.TabIndex = 4;
            this.chartLearning.Text = "Обучение";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageLearning);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1042, 757);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.labelError);
            this.tabPageMain.Controls.Add(this.textBoxError);
            this.tabPageMain.Controls.Add(this.tableLayoutPanelNeuronsLogs);
            this.tabPageMain.Controls.Add(this.groupBoxTestNetwork);
            this.tabPageMain.Controls.Add(this.groupBoxLearning);
            this.tabPageMain.Controls.Add(this.groupBoxNetworkParameters);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1034, 731);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главная панель";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(877, 242);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(96, 13);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "Ошибка обучения";
            // 
            // textBoxError
            // 
            this.textBoxError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxError.Location = new System.Drawing.Point(826, 261);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.Size = new System.Drawing.Size(200, 20);
            this.textBoxError.TabIndex = 14;
            // 
            // tableLayoutPanelNeuronsLogs
            // 
            this.tableLayoutPanelNeuronsLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelNeuronsLogs.ColumnCount = 4;
            this.tableLayoutPanelNeuronsLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxLinearWeights, 0, 3);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxSecondLayerThirdNeuron, 1, 2);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxFirstLayerThirdNeuron, 0, 2);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxSecondLayerSecondNeuron, 1, 1);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxFirstLayerSecondNeuron, 0, 1);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxSecondLayerFirstNeuron, 1, 0);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxFourthLayerFirstNeuron, 3, 0);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxFirstLayerFirstNeuron, 0, 0);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.tableLayoutPanelThirdLayerNeuronsLog, 2, 0);
            this.tableLayoutPanelNeuronsLogs.Controls.Add(this.richTextBoxOutputNeuronsLog, 2, 3);
            this.tableLayoutPanelNeuronsLogs.Location = new System.Drawing.Point(5, 127);
            this.tableLayoutPanelNeuronsLogs.Name = "tableLayoutPanelNeuronsLogs";
            this.tableLayoutPanelNeuronsLogs.RowCount = 4;
            this.tableLayoutPanelNeuronsLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNeuronsLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNeuronsLogs.Size = new System.Drawing.Size(815, 596);
            this.tableLayoutPanelNeuronsLogs.TabIndex = 13;
            // 
            // richTextBoxLinearWeights
            // 
            this.tableLayoutPanelNeuronsLogs.SetColumnSpan(this.richTextBoxLinearWeights, 2);
            this.richTextBoxLinearWeights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLinearWeights.Location = new System.Drawing.Point(3, 450);
            this.richTextBoxLinearWeights.Name = "richTextBoxLinearWeights";
            this.richTextBoxLinearWeights.ReadOnly = true;
            this.richTextBoxLinearWeights.Size = new System.Drawing.Size(400, 143);
            this.richTextBoxLinearWeights.TabIndex = 21;
            this.richTextBoxLinearWeights.Text = "";
            // 
            // richTextBoxSecondLayerThirdNeuron
            // 
            this.richTextBoxSecondLayerThirdNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSecondLayerThirdNeuron.Location = new System.Drawing.Point(206, 301);
            this.richTextBoxSecondLayerThirdNeuron.Name = "richTextBoxSecondLayerThirdNeuron";
            this.richTextBoxSecondLayerThirdNeuron.ReadOnly = true;
            this.richTextBoxSecondLayerThirdNeuron.Size = new System.Drawing.Size(197, 143);
            this.richTextBoxSecondLayerThirdNeuron.TabIndex = 20;
            this.richTextBoxSecondLayerThirdNeuron.Text = "";
            // 
            // richTextBoxFirstLayerThirdNeuron
            // 
            this.richTextBoxFirstLayerThirdNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFirstLayerThirdNeuron.Location = new System.Drawing.Point(3, 301);
            this.richTextBoxFirstLayerThirdNeuron.Name = "richTextBoxFirstLayerThirdNeuron";
            this.richTextBoxFirstLayerThirdNeuron.ReadOnly = true;
            this.richTextBoxFirstLayerThirdNeuron.Size = new System.Drawing.Size(197, 143);
            this.richTextBoxFirstLayerThirdNeuron.TabIndex = 19;
            this.richTextBoxFirstLayerThirdNeuron.Text = "";
            // 
            // richTextBoxSecondLayerSecondNeuron
            // 
            this.richTextBoxSecondLayerSecondNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSecondLayerSecondNeuron.Location = new System.Drawing.Point(206, 152);
            this.richTextBoxSecondLayerSecondNeuron.Name = "richTextBoxSecondLayerSecondNeuron";
            this.richTextBoxSecondLayerSecondNeuron.ReadOnly = true;
            this.richTextBoxSecondLayerSecondNeuron.Size = new System.Drawing.Size(197, 143);
            this.richTextBoxSecondLayerSecondNeuron.TabIndex = 18;
            this.richTextBoxSecondLayerSecondNeuron.Text = "";
            // 
            // richTextBoxFirstLayerSecondNeuron
            // 
            this.richTextBoxFirstLayerSecondNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFirstLayerSecondNeuron.Location = new System.Drawing.Point(3, 152);
            this.richTextBoxFirstLayerSecondNeuron.Name = "richTextBoxFirstLayerSecondNeuron";
            this.richTextBoxFirstLayerSecondNeuron.ReadOnly = true;
            this.richTextBoxFirstLayerSecondNeuron.Size = new System.Drawing.Size(197, 143);
            this.richTextBoxFirstLayerSecondNeuron.TabIndex = 17;
            this.richTextBoxFirstLayerSecondNeuron.Text = "";
            // 
            // richTextBoxSecondLayerFirstNeuron
            // 
            this.richTextBoxSecondLayerFirstNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSecondLayerFirstNeuron.Location = new System.Drawing.Point(206, 3);
            this.richTextBoxSecondLayerFirstNeuron.Name = "richTextBoxSecondLayerFirstNeuron";
            this.richTextBoxSecondLayerFirstNeuron.ReadOnly = true;
            this.richTextBoxSecondLayerFirstNeuron.Size = new System.Drawing.Size(197, 143);
            this.richTextBoxSecondLayerFirstNeuron.TabIndex = 16;
            this.richTextBoxSecondLayerFirstNeuron.Text = "";
            // 
            // richTextBoxFourthLayerFirstNeuron
            // 
            this.richTextBoxFourthLayerFirstNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFourthLayerFirstNeuron.Location = new System.Drawing.Point(612, 3);
            this.richTextBoxFourthLayerFirstNeuron.Name = "richTextBoxFourthLayerFirstNeuron";
            this.richTextBoxFourthLayerFirstNeuron.ReadOnly = true;
            this.tableLayoutPanelNeuronsLogs.SetRowSpan(this.richTextBoxFourthLayerFirstNeuron, 3);
            this.richTextBoxFourthLayerFirstNeuron.Size = new System.Drawing.Size(200, 441);
            this.richTextBoxFourthLayerFirstNeuron.TabIndex = 15;
            this.richTextBoxFourthLayerFirstNeuron.Text = "";
            // 
            // richTextBoxFirstLayerFirstNeuron
            // 
            this.richTextBoxFirstLayerFirstNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFirstLayerFirstNeuron.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxFirstLayerFirstNeuron.Name = "richTextBoxFirstLayerFirstNeuron";
            this.richTextBoxFirstLayerFirstNeuron.ReadOnly = true;
            this.richTextBoxFirstLayerFirstNeuron.Size = new System.Drawing.Size(197, 143);
            this.richTextBoxFirstLayerFirstNeuron.TabIndex = 3;
            this.richTextBoxFirstLayerFirstNeuron.Text = "";
            // 
            // tableLayoutPanelThirdLayerNeuronsLog
            // 
            this.tableLayoutPanelThirdLayerNeuronsLog.ColumnCount = 1;
            this.tableLayoutPanelThirdLayerNeuronsLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelThirdLayerNeuronsLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelThirdLayerNeuronsLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelThirdLayerNeuronsLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelThirdLayerNeuronsLog.Controls.Add(this.richTextBoxThirdLayerSecondNeuron, 0, 1);
            this.tableLayoutPanelThirdLayerNeuronsLog.Controls.Add(this.richTextBoxThirdLayerFirstNeuron, 0, 0);
            this.tableLayoutPanelThirdLayerNeuronsLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelThirdLayerNeuronsLog.Location = new System.Drawing.Point(409, 3);
            this.tableLayoutPanelThirdLayerNeuronsLog.Name = "tableLayoutPanelThirdLayerNeuronsLog";
            this.tableLayoutPanelThirdLayerNeuronsLog.RowCount = 2;
            this.tableLayoutPanelNeuronsLogs.SetRowSpan(this.tableLayoutPanelThirdLayerNeuronsLog, 3);
            this.tableLayoutPanelThirdLayerNeuronsLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelThirdLayerNeuronsLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelThirdLayerNeuronsLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelThirdLayerNeuronsLog.Size = new System.Drawing.Size(197, 441);
            this.tableLayoutPanelThirdLayerNeuronsLog.TabIndex = 12;
            // 
            // richTextBoxThirdLayerSecondNeuron
            // 
            this.richTextBoxThirdLayerSecondNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxThirdLayerSecondNeuron.Location = new System.Drawing.Point(3, 223);
            this.richTextBoxThirdLayerSecondNeuron.Name = "richTextBoxThirdLayerSecondNeuron";
            this.richTextBoxThirdLayerSecondNeuron.ReadOnly = true;
            this.richTextBoxThirdLayerSecondNeuron.Size = new System.Drawing.Size(191, 215);
            this.richTextBoxThirdLayerSecondNeuron.TabIndex = 11;
            this.richTextBoxThirdLayerSecondNeuron.Text = "";
            // 
            // richTextBoxThirdLayerFirstNeuron
            // 
            this.richTextBoxThirdLayerFirstNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxThirdLayerFirstNeuron.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxThirdLayerFirstNeuron.Name = "richTextBoxThirdLayerFirstNeuron";
            this.richTextBoxThirdLayerFirstNeuron.ReadOnly = true;
            this.richTextBoxThirdLayerFirstNeuron.Size = new System.Drawing.Size(191, 214);
            this.richTextBoxThirdLayerFirstNeuron.TabIndex = 10;
            this.richTextBoxThirdLayerFirstNeuron.Text = "";
            // 
            // richTextBoxOutputNeuronsLog
            // 
            this.tableLayoutPanelNeuronsLogs.SetColumnSpan(this.richTextBoxOutputNeuronsLog, 2);
            this.richTextBoxOutputNeuronsLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOutputNeuronsLog.Location = new System.Drawing.Point(409, 450);
            this.richTextBoxOutputNeuronsLog.Name = "richTextBoxOutputNeuronsLog";
            this.richTextBoxOutputNeuronsLog.ReadOnly = true;
            this.richTextBoxOutputNeuronsLog.Size = new System.Drawing.Size(403, 143);
            this.richTextBoxOutputNeuronsLog.TabIndex = 14;
            this.richTextBoxOutputNeuronsLog.Text = "";
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
            this.groupBoxTestNetwork.Location = new System.Drawing.Point(826, 6);
            this.groupBoxTestNetwork.Name = "groupBoxTestNetwork";
            this.groupBoxTestNetwork.Size = new System.Drawing.Size(200, 233);
            this.groupBoxTestNetwork.TabIndex = 6;
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
            31,
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
            85,
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
            92,
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
            27,
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
            45,
            0,
            0,
            0});
            // 
            // groupBoxLearning
            // 
            this.groupBoxLearning.Controls.Add(this.buttonStopLearning);
            this.groupBoxLearning.Controls.Add(this.buttonStartLearning);
            this.groupBoxLearning.Controls.Add(this.textBoxCurrentEpoch);
            this.groupBoxLearning.Controls.Add(this.labelCurrentEpoch);
            this.groupBoxLearning.Location = new System.Drawing.Point(212, 8);
            this.groupBoxLearning.Name = "groupBoxLearning";
            this.groupBoxLearning.Size = new System.Drawing.Size(200, 113);
            this.groupBoxLearning.TabIndex = 5;
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
            // textBoxCurrentEpoch
            // 
            this.textBoxCurrentEpoch.Location = new System.Drawing.Point(105, 29);
            this.textBoxCurrentEpoch.Name = "textBoxCurrentEpoch";
            this.textBoxCurrentEpoch.ReadOnly = true;
            this.textBoxCurrentEpoch.Size = new System.Drawing.Size(89, 20);
            this.textBoxCurrentEpoch.TabIndex = 13;
            // 
            // labelCurrentEpoch
            // 
            this.labelCurrentEpoch.AutoSize = true;
            this.labelCurrentEpoch.Location = new System.Drawing.Point(6, 31);
            this.labelCurrentEpoch.Name = "labelCurrentEpoch";
            this.labelCurrentEpoch.Size = new System.Drawing.Size(84, 13);
            this.labelCurrentEpoch.TabIndex = 2;
            this.labelCurrentEpoch.Text = "Текущая эпоха";
            // 
            // groupBoxNetworkParameters
            // 
            this.groupBoxNetworkParameters.Controls.Add(this.labelLearningPercent);
            this.groupBoxNetworkParameters.Controls.Add(this.numericUpDownLearningPercent);
            this.groupBoxNetworkParameters.Controls.Add(this.checkBoxShowNeuronsLog);
            this.groupBoxNetworkParameters.Controls.Add(this.buttonInitialize);
            this.groupBoxNetworkParameters.Controls.Add(this.labelCoefficient);
            this.groupBoxNetworkParameters.Controls.Add(this.numericUpDownCoefficient);
            this.groupBoxNetworkParameters.Location = new System.Drawing.Point(6, 8);
            this.groupBoxNetworkParameters.Name = "groupBoxNetworkParameters";
            this.groupBoxNetworkParameters.Size = new System.Drawing.Size(200, 113);
            this.groupBoxNetworkParameters.TabIndex = 4;
            this.groupBoxNetworkParameters.TabStop = false;
            this.groupBoxNetworkParameters.Text = "Параметры сети";
            // 
            // checkBoxShowNeuronsLog
            // 
            this.checkBoxShowNeuronsLog.AutoSize = true;
            this.checkBoxShowNeuronsLog.Location = new System.Drawing.Point(39, 66);
            this.checkBoxShowNeuronsLog.Name = "checkBoxShowNeuronsLog";
            this.checkBoxShowNeuronsLog.Size = new System.Drawing.Size(131, 17);
            this.checkBoxShowNeuronsLog.TabIndex = 14;
            this.checkBoxShowNeuronsLog.Text = "Показывать выходы";
            this.checkBoxShowNeuronsLog.UseVisualStyleBackColor = true;
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
            this.labelCoefficient.Location = new System.Drawing.Point(6, 21);
            this.labelCoefficient.Name = "labelCoefficient";
            this.labelCoefficient.Size = new System.Drawing.Size(126, 13);
            this.labelCoefficient.TabIndex = 2;
            this.labelCoefficient.Text = "Коэффициент обучения";
            // 
            // numericUpDownCoefficient
            // 
            this.numericUpDownCoefficient.DecimalPlaces = 3;
            this.numericUpDownCoefficient.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownCoefficient.Location = new System.Drawing.Point(138, 19);
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
            // tabPageLearning
            // 
            this.tabPageLearning.Controls.Add(this.chartLearning);
            this.tabPageLearning.Location = new System.Drawing.Point(4, 22);
            this.tabPageLearning.Name = "tabPageLearning";
            this.tabPageLearning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLearning.Size = new System.Drawing.Size(1034, 731);
            this.tabPageLearning.TabIndex = 1;
            this.tabPageLearning.Text = "Обучение";
            this.tabPageLearning.UseVisualStyleBackColor = true;
            // 
            // labelLearningPercent
            // 
            this.labelLearningPercent.AutoSize = true;
            this.labelLearningPercent.Location = new System.Drawing.Point(6, 46);
            this.labelLearningPercent.Name = "labelLearningPercent";
            this.labelLearningPercent.Size = new System.Drawing.Size(100, 13);
            this.labelLearningPercent.TabIndex = 16;
            this.labelLearningPercent.Text = "Процент  выборки";
            // 
            // numericUpDownLearningPercent
            // 
            this.numericUpDownLearningPercent.Location = new System.Drawing.Point(138, 44);
            this.numericUpDownLearningPercent.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLearningPercent.Name = "numericUpDownLearningPercent";
            this.numericUpDownLearningPercent.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownLearningPercent.TabIndex = 15;
            this.numericUpDownLearningPercent.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 757);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "TSK";
            ((System.ComponentModel.ISupportInitialize)(this.chartLearning)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tableLayoutPanelNeuronsLogs.ResumeLayout(false);
            this.tableLayoutPanelThirdLayerNeuronsLog.ResumeLayout(false);
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
            this.groupBoxNetworkParameters.ResumeLayout(false);
            this.groupBoxNetworkParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoefficient)).EndInit();
            this.tabPageLearning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearningPercent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLearning;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox groupBoxTestNetwork;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxTestResult;
        private System.Windows.Forms.Label labelTestResult;
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
        private System.Windows.Forms.Label labelThirdParameter;
        private System.Windows.Forms.NumericUpDown numericUpDownThirdParameter;
        private System.Windows.Forms.GroupBox groupBoxLearning;
        private System.Windows.Forms.Button buttonStopLearning;
        private System.Windows.Forms.Button buttonStartLearning;
        private System.Windows.Forms.TextBox textBoxCurrentEpoch;
        private System.Windows.Forms.Label labelCurrentEpoch;
        private System.Windows.Forms.GroupBox groupBoxNetworkParameters;
        private System.Windows.Forms.Button buttonInitialize;
        private System.Windows.Forms.Label labelCoefficient;
        private System.Windows.Forms.NumericUpDown numericUpDownCoefficient;
        private System.Windows.Forms.TabPage tabPageLearning;
        private System.Windows.Forms.CheckBox checkBoxShowNeuronsLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNeuronsLogs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelThirdLayerNeuronsLog;
        private System.Windows.Forms.RichTextBox richTextBoxThirdLayerSecondNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxThirdLayerFirstNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxSecondLayerThirdNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxFirstLayerThirdNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxSecondLayerSecondNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxFirstLayerSecondNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxSecondLayerFirstNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxFourthLayerFirstNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxFirstLayerFirstNeuron;
        private System.Windows.Forms.RichTextBox richTextBoxLinearWeights;
        private System.Windows.Forms.RichTextBox richTextBoxOutputNeuronsLog;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelLearningPercent;
        private System.Windows.Forms.NumericUpDown numericUpDownLearningPercent;
    }
}

