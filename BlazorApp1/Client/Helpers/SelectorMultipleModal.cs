namespace BlazorApp1.Client.Helpers
{
    public struct SelectorMultipleModal
    {
        public SelectorMultipleModal(string llave, string valor)
        {
            Llave = llave;
            Valor = valor;

        }
        public string Llave { get; set; }
        public string Valor { get; set; }
    }
}
