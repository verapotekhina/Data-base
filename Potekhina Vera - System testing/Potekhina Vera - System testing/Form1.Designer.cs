namespace Potekhina_Vera___System_testing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_showTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.button_solutionsUser = new System.Windows.Forms.Button();
            this.button_tasksOfAuthor = new System.Windows.Forms.Button();
            this.button_tasksWithComplexity = new System.Windows.Forms.Button();
            this.button_QuestionForTask = new System.Windows.Forms.Button();
            this.button_topRating = new System.Windows.Forms.Button();
            this.button_solutionOnLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_showTable
            // 
            this.button_showTable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_showTable.Location = new System.Drawing.Point(15, 704);
            this.button_showTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_showTable.Name = "button_showTable";
            this.button_showTable.Size = new System.Drawing.Size(315, 54);
            this.button_showTable.TabIndex = 2;
            this.button_showTable.Text = "Просмотр таблицы";
            this.button_showTable.UseVisualStyleBackColor = true;
            this.button_showTable.Click += new System.EventHandler(this.button_showTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 551);
            this.dataGridView1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "Авторы_задач", "Архив_задач", "Вопрос_автору", "Задача", "Общий_рейтинг", "Пользователи", "Решение",
                "Тесты_задач"
            });
            this.comboBox1.Location = new System.Drawing.Point(15, 655);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 36);
            this.comboBox1.TabIndex = 4;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_save.Location = new System.Drawing.Point(15, 771);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(315, 57);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Сохранение изменений";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem,
                this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem,
                this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem,
                this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem
            });
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1289, 31);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image =
                ((System.Drawing.Image) (resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(72, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image =
                ((System.Drawing.Image) (resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image =
                ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image =
                ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image =
                ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image =
                ((System.Drawing.Image) (resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(15, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите таблицу:";
            // 
            // button_solutionsUser
            // 
            this.button_solutionsUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_solutionsUser.Location = new System.Drawing.Point(335, 741);
            this.button_solutionsUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_solutionsUser.Name = "button_solutionsUser";
            this.button_solutionsUser.Size = new System.Drawing.Size(310, 87);
            this.button_solutionsUser.TabIndex = 8;
            this.button_solutionsUser.Text = "Показать все решения определенного пользователя";
            this.button_solutionsUser.UseVisualStyleBackColor = true;
            this.button_solutionsUser.Click += new System.EventHandler(this.button_solutionsUser_Click);
            // 
            // button_tasksOfAuthor
            // 
            this.button_tasksOfAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_tasksOfAuthor.Location = new System.Drawing.Point(651, 741);
            this.button_tasksOfAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_tasksOfAuthor.Name = "button_tasksOfAuthor";
            this.button_tasksOfAuthor.Size = new System.Drawing.Size(310, 87);
            this.button_tasksOfAuthor.TabIndex = 9;
            this.button_tasksOfAuthor.Text = "Показать все задачи определенного автора";
            this.button_tasksOfAuthor.UseVisualStyleBackColor = true;
            this.button_tasksOfAuthor.Click += new System.EventHandler(this.button_tasksOfAuthors_Click);
            // 
            // button_tasksWithComplexity
            // 
            this.button_tasksWithComplexity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_tasksWithComplexity.Location = new System.Drawing.Point(967, 741);
            this.button_tasksWithComplexity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_tasksWithComplexity.Name = "button_tasksWithComplexity";
            this.button_tasksWithComplexity.Size = new System.Drawing.Size(310, 87);
            this.button_tasksWithComplexity.TabIndex = 10;
            this.button_tasksWithComplexity.Text = "Все задачи со сложностью меньше, чем введенная";
            this.button_tasksWithComplexity.UseVisualStyleBackColor = true;
            this.button_tasksWithComplexity.Click += new System.EventHandler(this.button_tasksWithComplexity_Click);
            // 
            // button_QuestionForTask
            // 
            this.button_QuestionForTask.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_QuestionForTask.Location = new System.Drawing.Point(336, 620);
            this.button_QuestionForTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_QuestionForTask.Name = "button_QuestionForTask";
            this.button_QuestionForTask.Size = new System.Drawing.Size(309, 87);
            this.button_QuestionForTask.TabIndex = 11;
            this.button_QuestionForTask.Text = "Посмотреть все вопросы по номеру задачи";
            this.button_QuestionForTask.UseVisualStyleBackColor = true;
            this.button_QuestionForTask.Click += new System.EventHandler(this.button_QuestionForTask_Click);
            // 
            // button_topRating
            // 
            this.button_topRating.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_topRating.Location = new System.Drawing.Point(651, 620);
            this.button_topRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_topRating.Name = "button_topRating";
            this.button_topRating.Size = new System.Drawing.Size(310, 87);
            this.button_topRating.TabIndex = 12;
            this.button_topRating.Text = "Показать топ общего рейтинга";
            this.button_topRating.UseVisualStyleBackColor = true;
            this.button_topRating.Click += new System.EventHandler(this.button_topRating_Click);
            // 
            // button_solutionOnLanguage
            // 
            this.button_solutionOnLanguage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_solutionOnLanguage.Location = new System.Drawing.Point(967, 620);
            this.button_solutionOnLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_solutionOnLanguage.Name = "button_solutionOnLanguage";
            this.button_solutionOnLanguage.Size = new System.Drawing.Size(310, 87);
            this.button_solutionOnLanguage.TabIndex = 13;
            this.button_solutionOnLanguage.Text = "Все решения на определенном языке программирования";
            this.button_solutionOnLanguage.UseVisualStyleBackColor = true;
            this.button_solutionOnLanguage.Click += new System.EventHandler(this.button_solutionOnLanguage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            this.ClientSize = new System.Drawing.Size(1289, 852);
            this.Controls.Add(this.button_solutionOnLanguage);
            this.Controls.Add(this.button_topRating);
            this.Controls.Add(this.button_QuestionForTask);
            this.Controls.Add(this.button_tasksWithComplexity);
            this.Controls.Add(this.button_tasksOfAuthor);
            this.Controls.Add(this.button_solutionsUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_showTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Potekhina Vera - System testing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_showTable;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_solutionsUser;
        private System.Windows.Forms.Button button_tasksOfAuthor;
        private System.Windows.Forms.Button button_tasksWithComplexity;
        private System.Windows.Forms.Button button_QuestionForTask;
        private System.Windows.Forms.Button button_topRating;
        private System.Windows.Forms.Button button_solutionOnLanguage;
    }
}