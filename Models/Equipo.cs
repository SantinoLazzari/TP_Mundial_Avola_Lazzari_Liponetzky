using System;
namespace TP_Mundial_Avola_Lazzari_Liponetzky.Models;
public class Equipo
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

    public Equipo(){
       
        _IdEquipo=0;
        _Nombre="";
        _Escudo="";
        _Camiseta="";
        _Continente="";
        _CopasGanadas=0;


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

        
    public string Escudo 
        {
            get { return _Escudo; }
            set { _Escudo=value; }
        }
    
    public string Camiseta 
        {
            get { return _Camiseta; }
            set { _Camiseta=value; }
        }
    
    public string Continente 
        {
            get { return _Continente; }
            set { _Continente=value; }
        }
    
    public int CopasGanadas 
        {
            get { return _CopasGanadas; }
            set { _CopasGanadas=value; }
        }
}