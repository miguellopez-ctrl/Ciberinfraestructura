namespace HolaMundo;

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
        lblPass = new Label();
        txtPass = new TextBox();
        lblConfirm = new Label();
        txtConfirm = new TextBox();
        btnValidar = new Button();
        SuspendLayout();
        //
        // lblPass
        //
        lblPass.AutoSize = true;
        lblPass.Location = new Point(30, 32);
        lblPass.Name = "lblPass";
        lblPass.Size = new Size(74, 15);
        lblPass.TabIndex = 0;
        lblPass.Text = "Contraseña:";
        //
        // txtPass
        //
        txtPass.Location = new Point(170, 29);
        txtPass.Name = "txtPass";
        txtPass.Size = new Size(190, 23);
        txtPass.TabIndex = 1;
        //
        // lblConfirm
        //
        lblConfirm.AutoSize = true;
        lblConfirm.Location = new Point(30, 72);
        lblConfirm.Name = "lblConfirm";
        lblConfirm.Size = new Size(132, 15);
        lblConfirm.TabIndex = 2;
        lblConfirm.Text = "Confirmar contraseña:";
        //
        // txtConfirm
        //
        txtConfirm.Location = new Point(170, 69);
        txtConfirm.Name = "txtConfirm";
        txtConfirm.Size = new Size(190, 23);
        txtConfirm.TabIndex = 3;
        //
        // btnValidar
        //
        btnValidar.Location = new Point(170, 110);
        btnValidar.Name = "btnValidar";
        btnValidar.Size = new Size(190, 30);
        btnValidar.TabIndex = 4;
        btnValidar.Text = "Validar";
        btnValidar.UseVisualStyleBackColor = true;
        btnValidar.Click += btnValidar_Click;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 170);
        Controls.Add(lblPass);
        Controls.Add(txtPass);
        Controls.Add(lblConfirm);
        Controls.Add(txtConfirm);
        Controls.Add(btnValidar);
        Name = "Form1";
        Text = "HolaMundo";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblPass;
    private TextBox txtPass;
    private Label lblConfirm;
    private TextBox txtConfirm;
    private Button btnValidar;
}
