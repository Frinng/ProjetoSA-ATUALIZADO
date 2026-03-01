namespace ProjetoSA_v2;
using System.Windows.Forms;

public class ValidadorLogin {

    public static string FazerLogin(string usuario, string senha) {
        try {
            
            if ("ADMIN" == usuario && "ADMIN" == senha)
            {
                if (usuario.Equals("ADMIN", StringComparison.OrdinalIgnoreCase) && senha.Length < 5)
                {
                    return "ADMIN";
                }
                else
                {
                    return "SUCESSO";
                }
            }

            return "FALHA";
        }
        catch (Exception ex) {
            MessageBox.Show("Erro ao acessar planilha: " + ex.Message,
                "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return "ERRO";
        }
    }
}