using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Касса_БЕЛ_ЖД
{
    class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdateПоезда()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Поезда", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(string Тип_поезда, int Вагон, double Доплата )
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Поезда(тип_поезда, количество_вагонов, Доплата_за_тип_поезда) VALUES(@Тип_поезда, Вагон, Доплата)", connection);
            command.Parameters.AddWithValue("Тип_поезда", Тип_поезда);
            command.Parameters.AddWithValue("Вагон", Вагон);
            command.Parameters.AddWithValue("Доплата", Доплата);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Поезда", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }
        public void UpdateTable(string Тип_поезда, int Вагон, double Доплата, int ID)
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE Поезда SET тип_поезда = @Тип_поезда, количество_вагонов = Вагон, Доплата_за_тип_поезда = Доплата WHERE №_поезда = ID", connection);
            command.Parameters.AddWithValue("Тип_поезда", Тип_поезда);
            command.Parameters.AddWithValue("Вагон", Вагон);
            command.Parameters.AddWithValue("Доплата", Доплата);
            command.Parameters.AddWithValue("№_поезда", ID);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Поезда", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void Delete(int ID)
        {
                connection.Open();
                command = new OleDbCommand($"DELETE FROM Поезда WHERE (№_поезда) = {ID}", connection);
                command.ExecuteNonQuery();
                dataAdapter = new OleDbDataAdapter("SELECT * FROM Поезда", connection);
                bufferTable.Clear();
                dataAdapter.Fill(bufferTable);
                connection.Close();
        }

        public DataTable UpdateМаршруты()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Маршруты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void UpdateMarhrut(string Наименование_маршрута, string Линии_перевозок, int Длинна_маршрута_км, double Стоимость_за_1км, int ID)
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE Маршруты SET Наименование_маршрута = @Наименование_маршрута, Линии_перевозок = @Линии_перевозок, Длинна_маршрута_км = @Длинна_маршрута_км, Стоимость_за_1км = @Стоимость_за_1км WHERE (№_маршрута) = {ID}", connection);
            command.Parameters.AddWithValue("Наименование_маршрута", Наименование_маршрута);
            command.Parameters.AddWithValue("Линии_перевозок", Линии_перевозок);
            command.Parameters.AddWithValue("Длинна_маршрута_км", Длинна_маршрута_км);
            command.Parameters.AddWithValue("Стоимость_за_1км", Стоимость_за_1км);
            command.Parameters.AddWithValue("№_маршрута", ID);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Маршруты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void AddМаршруты( string Наименование_маршрута, string Линии_перевозок, int Длинна_маршрута_км, double Стоимость_за_1км)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Маршруты(Наименование_маршрута, Линии_перевозок, Длинна_маршрута_км, Стоимость_за_1км) VALUES(@Наименование_маршрута, @Линии_перевозок, Длинна_маршрута_км, Стоимость_за_1км)", connection);
            command.Parameters.AddWithValue("Наименование_маршрута", Наименование_маршрута);
            command.Parameters.AddWithValue("Линии_перевозок", Линии_перевозок);
            command.Parameters.AddWithValue("Длинна_маршрута_км", Длинна_маршрута_км);
            command.Parameters.AddWithValue("Стоимость_за_1км", Стоимость_за_1км);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Маршруты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }
        public void DeleteМаршруты(int ID)
        {
                connection.Open();
                command = new OleDbCommand($"DELETE FROM Маршруты WHERE (№_маршрута) = {ID}", connection);
                command.ExecuteNonQuery();
                dataAdapter = new OleDbDataAdapter("SELECT * FROM Маршруты", connection);
                bufferTable.Clear();
                dataAdapter.Fill(bufferTable);
                connection.Close();
        }

        public DataTable UpdateПассажиры()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Пассажиры", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddПассажиры(string Фамилия, string Имя, string Отчество, int ID_адреса, int ID_телефона)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Пассажиры(фамилия, имя, отчество, ID_адресса, ID_телефона) VALUES(@Фамилия, @Имя, @Отчество , ID_адреса, ID_телефона)", connection);
            command.Parameters.AddWithValue("Фамилия", Фамилия);
            command.Parameters.AddWithValue("Имя", Имя);
            command.Parameters.AddWithValue("Отчество", Отчество);
            command.Parameters.AddWithValue("ID_адреса", ID_адреса);
            command.Parameters.AddWithValue("ID_телефона", ID_телефона);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Пассажиры", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void UpdateClient(string Фамилия, string Имя, string Отчество, int ID_адреса, int ID_телефона, int ID_пасажира)
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE Пассажиры SET фамилия = @Фамилия, имя = @Имя, отчество = @Отчество, ID_адресса = @ID_адреса, ID_телефона = @ID_телефона WHERE id_пассажира = ID_пасажира", connection);
            command.Parameters.AddWithValue("Фамилия", Фамилия);
            command.Parameters.AddWithValue("Имя", Имя);
            command.Parameters.AddWithValue("Отчество", Отчество);
            command.Parameters.AddWithValue("ID_адреса", ID_адреса);
            command.Parameters.AddWithValue("ID_телефона", ID_телефона);
            command.Parameters.AddWithValue("ID_пасажира", ID_пасажира);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Пассажиры", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void DeleteПассажиры(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Пассажиры WHERE (id_пассажира) = {ID}", connection);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Пассажиры", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public DataTable UpdateАдреса()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Адреса", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void UpdateAdres(string Город, string Улица, string Дом, string Квартира, int ID)
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE Адреса SET  Город = @Город, Улица = @Улица, Дом = @Дом, Квартира = @Квартира WHERE ID_адресса = ID", connection);
            command.Parameters.AddWithValue("Город", Город);
            command.Parameters.AddWithValue("Улица", Улица);
            command.Parameters.AddWithValue("Дом", Дом);
            command.Parameters.AddWithValue("Квартира", Квартира);
            command.Parameters.AddWithValue("ID_адресса", ID);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Адреса", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }
        public void AddАдреса(string Город, string Улица, string Дом, string Квартира)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Адреса(Город, Улица, Дом, Квартира) VALUES(@Город, @Улица, @Дом, @Квартира)", connection);
            command.Parameters.AddWithValue("Город", Город);
            command.Parameters.AddWithValue("Улица", Улица);
            command.Parameters.AddWithValue("Дом", Дом);
            command.Parameters.AddWithValue("Квартира", Квартира);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Адреса", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }
        public void DeleteАдреса(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Адреса WHERE (ID_адресса) = {ID}", connection);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Адреса", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public DataTable UpdateТелефоны()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Телефоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void UpdateTel(string Телефон, int ID, string Доп_Телефон = "" )
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE  Телефоны SET  телефон = @Телефон, дополнительный_телефон = @Доп_Телефон WHERE ID_телефона = ID", connection);
            command.Parameters.AddWithValue("Телефон", Телефон);
            command.Parameters.AddWithValue("Доб_Телефон", Доп_Телефон);
            command.Parameters.AddWithValue("ID_телефона", ID);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Телефоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void AddТелефоны(string Телефон, string Доб_Телефон = "")
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Телефоны(телефон, дополнительный_телефон) VALUES(@Телефон, @Доб_Телефон)", connection);
            command.Parameters.AddWithValue("Телефон", Телефон);
            command.Parameters.AddWithValue("Доб_Телефон", Доб_Телефон);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Телефоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }
        public void DeleteТелефоны(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Телефоны WHERE (ID_телефона) = {ID}", connection);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Телефоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }
        public DataTable UpdateВагоны()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Вагоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void UpdateVagon(string Тип_вагона, double Доплата, int ID_вагона)
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE  Вагоны SET тип_вагона = @Тип_вагона , доплата = @Доплата WHERE ID_вагона = {ID_вагона}", connection);
            command.Parameters.AddWithValue("Тип_вагона", Тип_вагона);
            command.Parameters.AddWithValue("Доплата", Доплата);
            command.Parameters.AddWithValue("ID_вагона", ID_вагона);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Вагоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void AddВагоны(string Тип_вагона,  double Доплата)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Вагоны(тип_вагона, доплата) VALUES(@Тип_вагона, Доплата)", connection);
            command.Parameters.AddWithValue("Тип_вагона", Тип_вагона);
            command.Parameters.AddWithValue("Доплата", Доплата);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Вагоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void DeleteВагоны(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Вагоны WHERE (ID_вагона) = {ID}", connection);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Вагоны", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public DataTable UpdateБилеты()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Билеты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void DeleteБилеты(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Билеты WHERE (№_билета) = {ID}", connection);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Билеты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public void AddTickets(int N_поезда, int N_маршрута, DateTime Дата_и_время_отправления, DateTime Дата_и_время_прибытия, int Пассажир, int N_вагона, int ID_вагона, double Стоимост_маршрута, double Полная_стоимость)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Билеты(№_поезда, №_маршрута, Дата_и_время_отправления, Дата_и_время_прибытия, Пассажир, №_вагона, ID_вагона, Стоимост_маршрута, Полная_стоимость) VALUES( N_поезда, N_маршрута, Дата_и_время_отправления, Дата_и_время_прибытия , Пассажир, N_вагона, ID_вагона, Стоимост_маршрута, Полная_стоимость)", connection);
            command.Parameters.AddWithValue("N_поезда", N_поезда);
            command.Parameters.AddWithValue("N_маршрута", N_маршрута);
            command.Parameters.AddWithValue("Дата_и_время_отправления", Дата_и_время_отправления);
            command.Parameters.AddWithValue("Дата_и_время_прибытия", Дата_и_время_прибытия);
            command.Parameters.AddWithValue("Пассажир", Пассажир);
            command.Parameters.AddWithValue("N_вагона", N_вагона);
            command.Parameters.AddWithValue("ID_вагона", ID_вагона);
            command.Parameters.AddWithValue("Стоимост_маршрута", Стоимост_маршрута);
            command.Parameters.AddWithValue("Полная_стоимость", Полная_стоимость);
            command.ExecuteNonQuery();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Билеты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
        }

        public DataTable SelectTime(int Start_date)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Билеты WHERE (№_маршрута) = {Start_date}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable SelectOne(string Route)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT Наименование_маршрута, Дата_и_время_отправления, Дата_и_время_прибытия, фамилия, имя, отчество, Город, Улица, Дом FROM Билеты, Пассажиры, Маршруты, Адреса WHERE (Наименование_маршрута) = '{Route}' AND Пассажиры.ID_адресса = Адреса.ID_адресса AND Билеты.Пассажир = Пассажиры.id_пассажира AND Билеты.№_маршрута = Маршруты.№_маршрута ", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable SelectTwo(string Type)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT Наименование_маршрута, Длинна_маршрута_км, Стоимость_маршрута, тип_вагона, доплата, тип_поезда, Доплата_за_тип_поезда, Дата_и_время_отправления, Дата_и_время_прибытия, (Стоимость_маршрута + доплата + Доплата_за_тип_поезда) AS 'Стоимость_доплат' FROM Билеты, Вагоны, Маршруты, Поезда WHERE (тип_вагона) = '{Type}' AND Билеты.ID_вагона = Вагоны.ID_вагона AND Билеты.№_поезда = Поезда.№_поезда AND Билеты.№_маршрута = Маршруты.№_маршрута", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable SelectThree(string Street)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT фамилия, имя, отчество, Улица, Город, Дом, Квартира, телефон, дополнительный_телефон FROM Пассажиры, Адреса, Телефоны WHERE (Улица) = '{Street}' AND Пассажиры.ID_адресса =  Адреса.ID_адресса AND Пассажиры.ID_телефона = Телефоны.ID_телефона", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable SelectFour(string Tayp)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT №_билета, Наименование_маршрута, Линии_перевозок, тип_поезда, количество_вагонов, Длинна_маршрута_км, Стоимость_за_1км, Доплата_за_тип_поезда, ((Длинна_маршрута_км * Стоимость_за_1км) + Доплата_за_тип_поезда) AS Стоимость_с_доплатой FROM Билеты, Поезда, Маршруты WHERE (тип_поезда) = '{Tayp}' AND Билеты.№_поезда = Поезда.№_поезда AND Билеты.№_маршрута = Маршруты.№_маршрута", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable SearchАдреса(string Sity, string Street)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Адреса WHERE (Город) = '{Sity}' AND (Улица) = '{Street}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable SearchВагоны(string Tayp)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Вагоны WHERE (тип_вагона) = '{Tayp}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable SearchМаршруты(string N)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Маршруты WHERE (Наименование_маршрута) = '{N}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable SearchПассажиры(string F, string N, string O)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Пассажиры WHERE (фамилия) = '{F}' AND (имя) = '{N}' AND (отчество) = '{O}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable SearchПоезда(string Tayp)
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Поезда WHERE (тип_поезда) = '{Tayp}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
    }
}

