using System.Text.RegularExpressions;

namespace HolaMundo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Ejecucion del boton de validar
    private void btnValidar_Click(object? sender, EventArgs e)
    {
        // Contraseña escrita por el usuario
        string pass = txtPass.Text;

        // Expresión regular: minuscula, mayuscula, simbolo y numero
        string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

        // Validacion 1 contraseña con expresión
        if (!Regex.IsMatch(pass, patron))
        {
            // Mensajes de validacion que no se cumple
            string mensaje = "La contraseña debe contener al menos:\n\n";

            if (!Regex.IsMatch(pass, "[A-Z]"))
                mensaje += "- Una letra mayúscula\n";

            if (!Regex.IsMatch(pass, "[a-z]"))
                mensaje += "- Una letra minúscula\n";

            if (!Regex.IsMatch(pass, @"\d"))
                mensaje += "- Un número\n";

            if (!Regex.IsMatch(pass, @"[\W_]"))
                mensaje += "- Un símbolo\n";

            MessageBox.Show(mensaje, "Contraseña no válida");
            return; 
        }

        // Validacion 2 contraseñas iguales
        if (pass != txtConfirm.Text)
        {
            MessageBox.Show("Las contraseñas no coinciden.", "Contraseña no válida");
            return;
        }

        // Confirmación de contraeseña valida
        MessageBox.Show("La contraseña ha sido validada");
    }
}
