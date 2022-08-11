using System;
namespace TP_Mundial_Avola_Lazzari_Liponetzky;
public class Jugador
{
    private  int _IdJugador;
    private  int _IdEquipo;
    private  string _Nombre;
    private  DateTime _FechaNacimiento;
    private  string _Foto;
    private  string _EquipoActual;

    public Jugador (int idEquipo, string nombre, DateTime fechaNacimiento, string foto, string equipoActual)
    {
        _IdEquipo=idEquipo;
        _Nombre=nombre;
        _FechaNacimiento=fechaNacimiento;
        _Foto=foto;
        _EquipoActual=equipoActual;
    }

    public int IdJugador 
        {
            get { return _IdJugador; }
            set { _IdJugador=value; }
        }
    
    public int IdEquipo 
        {
            get { return _IdEquipo; }
            set { _IdEquipo=value; }
        }
    
    public string Nombre 
        {
            get { return _Nombre; }
            set { _Nombre=value; }
        }
    
    public DateTime FechaNacimiento 
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento=value; }
        }
    
    public string Foto 
        {
            get { return _Foto; }
            set { _Foto=value; }
        }
    
    public string EquipoActual 
        {
            get { return _EquipoActual; }
            set { _EquipoActual=value; }
        }

}

