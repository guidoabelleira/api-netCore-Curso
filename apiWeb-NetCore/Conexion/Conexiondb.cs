namespace apiWeb_NetCore.Conexion
{
    public class Conexiondb
    {
        private string connectionString = string.Empty;
        public Conexiondb()     
        {
            var constructor = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.json").Build();
            connectionString = constructor.GetSection("ConnectionStrings:conexionmaestra").Value;
        }
        public string cadenaSQL()
        {
            return connectionString;
        }
    }
}
