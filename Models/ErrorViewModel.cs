namespace TP_Mundial_Avola_Lazzari_Liponetzky.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

 class Equipo
{
    private  int _IdEquipo;
    private  string _Nombre;
    private  string _Escudo;
    private  string _Camiseta;
    private  string _Continente;
    private  int _CopasGanadas;

    
    public Equipo ( int idEquipo, string nombre, string escudo , string camiseta, string continente, int copasGanadas)
    {
        _IdEquipo=idEquipo;
        _Nombre=nombre;
        _Escudo=escudo;
        _Camiseta=camiseta;
        _Continente=continente;
        _CopasGanadas=copasGanadas;
    }

    public string Nombre 
        {
            get { return _Nombre; }
        }


     
}