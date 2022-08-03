namespace TP_Mundial_Avola_Lazzari_Liponetzky.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public class BD {

    private static string _connectionString = 
        @"Server=A-PHZ2-CIDI-032\;DataBase=TP06-Avola,Lazzari,Liponetzky;Trusted_Connection=True";
        // preguntar a pascuí o a juli o a sulivan/niño

        public static void AgregarJugador(Jugador jug)
        {
            string sql = "INSERT INTO Jugadores VALUES (@pIdJugador, @pIdEquipo, @pNombre,@pFechaNacimiento,@pFoto,@pEquipoActual )";
            using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pNombre = jug.Nombre, pIdEquipo = jug.IdEquipo, pFechaNacimiento = jug.FechaNacimiento, pFoto=jug.Foto, pEquipoActual=jug.EquipoActual });
            }
        }
        public static void AgregarEquipo(Equipo equi)
        {
            string sql = "INSERT INTO Equipos VALUES (@pIdEquipo, @pNombre,@pEscudo,@pCamiseta,@pContinente, @pCopasGanadas)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pNombre = equi.Nombre, pIdEquipo = equi.IdEquipo, pEscudo = equi.Escudo, pCamiseta = equi.Camiseta, pContinente = equi.Continente, pCopasGanadas = equi.CopasGanadas});
            }
        }
        public static void EliminarJugador(int idJugador){
        string sql = "DELETE FROM Jugador WHERE IdJugador = @pIdJugador";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pIdJugador = idJugador });
        }
        }
        public static Equipo VerInfoEquipo(int idEquipo){
        Equipo equipo;
        string sql = "SELECT * FROM Equipo WHERE idEquipo = @pIdEquipo";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            equipo= db.QueryFirstOrDefault<Equipo>(sql, new { pIdEquipo = idEquipo });
        }
        return equipo;
        }
        public static Jugador VerInfoJugador(int idJugador){
        Jugador jugador;
        string sql = "SELECT * FROM Jugador WHERE idJugador = @pidJugador";
        using(SqlConnection db = new SqlConnection(_connectionString)){
           jugador=db.QueryFirstOrDefault<Jugador>(sql, new { pidJugador = idJugador });
        }
        return jugador;
        }
        public static List<Equipo> ListarEquipos(){
        List<Equipo> Lista = new List<Equipo>();
        string sql = "SELECT * FROM Equipo";
        using(SqlConnection db = new SqlConnection(_connectionString)){
        Lista = db.Query<Equipo>(sql).ToList();
        }
        return Lista;
    }
        public static List<Jugador> ListarJugador(int idEquipo){
        List<Jugador> lista = new List<Jugador>();
        string sql = "SELECT * FROM Jugador";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            lista = db.Query<Jugador>(sql).ToList();
        }
        return lista;
    }
        
}
