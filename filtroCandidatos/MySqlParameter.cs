namespace filtroCandidatos
{
    internal class MySqlParameter
    {
        private string v;
        private string confirmacao;

        public MySqlParameter(string v, string confirmacao)
        {
            this.v = v;
            this.confirmacao = confirmacao;
        }
    }
}