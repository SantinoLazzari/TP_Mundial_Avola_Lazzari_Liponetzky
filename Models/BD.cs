namespace TP_Mundial_Avola_Lazzari_Liponetzky;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public class BD {

    private static string _connectionString = 
        @"Server=A-AMI-201;DataBase=TP06-Avola,Lazzari,Liponetzky;Trusted_Connection=True";
        // preguntar a pascuí o a juli o a sulivan/niño

        public static void AgregarJugador(Jugador jug)
        {
            string sql = "INSERT INTO Peliculas VALUES (@pIdJugador, @pIdEquipo, @pNombre,@pFechaNacimiento,@pFoto,@pEquipoActual )";
            using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pNombre = jug.Nombre, pIdEquipo = jug.IdEquipo, pFechaNacimiento = jug.FechaNacimiento, pFoto=jug.Foto, pEquipoActual=jug.EquipoActual });
            }
        }
        public static void EliminarJugador(int idJugador){
        string sql = "DELETE FROM Jugador WHERE IdJugador = @pIdJugador";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pIdJugador = idJugador });
        }
        }
        public static void VerInfoEquipo(int idEquipo){
        string sql = "SELECT * FROM Equipo WHERE idEquipo = @pIdEquipo";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pIdEquipo = idEquipo });
        }
        }
        public static void VerInfoJugador(int idJugador){
        string sql = "SELECT * FROM Jugador WHERE idJugador = @pidJugador";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new { pidJugador = idJugador });
        }
        }
        public static List<Equipo> ListarEquipos(){
        List<Equipo> lista = new List<Equipo>();
        string sql = "SELECT * FROM Equipo";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            lista = db.Query<Equipo>(sql).ToList();
        }
        return lista;
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
