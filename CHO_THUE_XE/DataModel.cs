using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace CHO_THUE_XE
{
    class DataModel
    {
        System.Data.SqlClient.SqlConnectionStringBuilder builder;
        SqlConnection conn;
        public DataModel()
        {
            builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = ".\\SQLEXPRESS";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "QLCHTX";
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            builder.UserID = userName;
            builder["Password"] = "";
            conn = new SqlConnection(builder.ConnectionString);
            conn.Open();
           /* builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = "171.244.61.127";
            builder["integrated Security"] = false;
            builder["Initial Catalog"] = "QLCHDT";
            builder.UserID = "sa";
            builder["Password"] = "Nguyen292003.";
            conn = new SqlConnection(builder.ConnectionString);
            conn.Open();*/
        }


        public List<Dictionary<string, string>> FetchAllRow()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT MaNV, MaLoai, TenNV, NgayVaoLam, SoDT, CaLam, ChiNhanhCongTac, NgaySinh, QueQuan, Email, TinhTrangNV FROM NhanVien";

            SqlCommand command = new SqlCommand(sqlQuery, this.conn);


            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["MaNV"] = reader["MaNV"].ToString();
                    column["MaLoai"] = reader["MaLoai"].ToString();
                    column["TenNV"] = reader["TenNV"].ToString();
                    column["NgayVaoLam"] = reader["NgayVaoLam"].ToString();
                    column["SoDT"] = reader["SoDT"].ToString();
                    column["CaLam"] = reader["CaLam"].ToString();
                    column["ChiNhanhCongTac"] = reader["ChiNhanhCongTac"].ToString();
                    column["NgaySinh"] = reader["NgaySinh"].ToString();
                    column["QueQuan"] = reader["QueQuan"].ToString();
                    column["Email"] = reader["Email"].ToString();
                    column["TinhTrangNV"] = reader["TinhTrangNV"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

        public byte[] loadImg(string id)
        {
            string sqlQuery = "Select Avatar from NhanVien where MaNv = @val1";
            // int result = command.ExecuteNonQuery();
            byte[] ava = null;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.Parameters.AddWithValue("@val1", id);
                try
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Avatar"] != DBNull.Value)
                        {
                            ava = (byte[])reader["Avatar"];
                        }
                        else ava = null;


                    }
                    reader.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
                return ava;
            }
        }

        public bool checkIfUserExist(string email)
        {
            string addCmd = "Select COUNT(*) from NhanVien where Email = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", email);
                try
                {
                    int count = (int)comm.ExecuteScalar();
                    return count>0;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }
        public bool checkIfNvExistInDangNhap(string email)
        {
            string addCmd = "Select COUNT(*) from DangNhap dn, NhanVien nv where dn.MaNV = nv.MaNV and nv.email=@email";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@email", email);
                try
                {
                    int count = (int)comm.ExecuteScalar();
                    return count > 0;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }
        public bool updatePassword(int maNV,String hashPassword)
        {
            string addCmd = "Update DangNhap set MatKhau = @val2 WHERE MaNV = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", maNV);
                comm.Parameters.AddWithValue("@val2", hashPassword);
                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }
        public int getMaNhanVien(string email)
        {
            string sqlQuery = "Select MaNV from NhanVien where Email = @val1";
            SqlCommand comm = new SqlCommand(sqlQuery, this.conn);
            int MaNV = 0;
            try
            {
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.Parameters.AddWithValue("@val1", email);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    MaNV = Int32.Parse(reader["MaNV"].ToString());
                    break;
                }
                reader.Close();
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            return MaNV;
         }
        public string getName(string email)
        {
            string sqlQuery = "select* from DangNhap,NhanVien where NhanVien.MaNV = DangNhap.MaNV and NhanVien.Email=@email";
            SqlCommand comm = new SqlCommand(sqlQuery, this.conn);
            String name = "";
            try
            {
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.Parameters.AddWithValue("@email", email);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    name = reader["TenDangNhap"].ToString();
                    break;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return name;
        }

        public bool AddNewRow(string tid, string name, string shift, string fd, string dob, string ht, string branch, string phone, string email, string status, byte[] img)
        {
            string addCmd = "INSERT INTO NhanVien (MaLoai, TenNV, NgayVaoLam, SoDT, CaLam, ChiNhanhCongTac, NgaySinh, QueQuan, Email, TinhTrangNV, Avatar) values (@val1, @val2, @val3, @val4, @val5,@val6, @val7, @val8, @val9, @val10, @val11)";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", tid);
                comm.Parameters.AddWithValue("@val2", name);
                comm.Parameters.AddWithValue("@val3", fd);
                comm.Parameters.AddWithValue("@val4", phone);
                comm.Parameters.AddWithValue("@val5", shift);
                comm.Parameters.AddWithValue("@val6", branch);
                comm.Parameters.AddWithValue("@val7", dob);
                comm.Parameters.AddWithValue("@val8", ht);
                comm.Parameters.AddWithValue("@val9", email);
                comm.Parameters.AddWithValue("@val10", status);
                comm.Parameters.AddWithValue("@val11", img);
                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool RemoveRow(string id)
        {
            string addCmd = "DELETE FROM NhanVien where MaNV = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", id);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool UpdateRow(string sid, string tid, string name, string shift, string fd, string dob, string ht, string branch, string phone, string email, string status, byte[] img )
        {
            string addCmd = "update NhanVien set MaLoai = @val2,TenNV = @val3, NgayVaoLam =  @val5, SoDT = @val9, CaLam =  @val4, ChiNhanhCongTac = @val8, NgaySinh = @val6 , QueQuan = @val7, Email = @val10 , TinhTrangNV = @val11, Avatar = @val12 where MaNV = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", sid);
                comm.Parameters.AddWithValue("@val2", tid);
                comm.Parameters.AddWithValue("@val3", name);
                comm.Parameters.AddWithValue("@val4", shift);
                comm.Parameters.AddWithValue("@val5", fd);
                comm.Parameters.AddWithValue("@val6", dob);
                comm.Parameters.AddWithValue("@val7", ht);
                comm.Parameters.AddWithValue("@val8", branch);
                comm.Parameters.AddWithValue("@val9", phone);
                comm.Parameters.AddWithValue("@val10", email);
                comm.Parameters.AddWithValue("@val11", status);
                comm.Parameters.AddWithValue("@val12", img);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public List<Dictionary<string, string>> FetchAllRowDv(string brandFilter, string typeFilter, string modelFilter)
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT Id, Name, Brand, Type, Model FROM Car where 1=1 ";
            SqlCommand command;
            if (brandFilter != null && !brandFilter.Equals(""))
            {
                sqlQuery+= " AND Brand = @val1 ";
            }
            if (typeFilter != null && !typeFilter.Equals(""))
            {
                sqlQuery += " AND Type = @val2 ";
            }
            if (modelFilter != null && !modelFilter.Equals(""))
            {
                sqlQuery += " AND Model = @val3 ";
            }


             command = new SqlCommand(sqlQuery, this.conn);
            if (brandFilter != null && !brandFilter.Equals(""))
            {
                command.Parameters.AddWithValue("@val1", brandFilter);

            }
            if (typeFilter != null && !typeFilter.Equals(""))
            {
                command.Parameters.AddWithValue("@val2", typeFilter);


            }
            if (modelFilter != null && !modelFilter.Equals(""))
            {
                command.Parameters.AddWithValue("@val3", modelFilter);

            }

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["Id"] = reader["Id"].ToString();
                    column["Name"] = reader["Name"].ToString();
                    column["Brand"] = reader["Brand"].ToString();
                    column["Type"] = reader["Type"].ToString();
                    column["Model"] = reader["Model"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

        public byte[] loadImgDv(int id)
        {
            string sqlQuery = "Select Picture from Car where Id = @val1";
            // int result = command.ExecuteNonQuery();
            byte[] pic;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.Parameters.AddWithValue("@val1", id);
                try
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    reader.Read();
                    pic = (byte[])reader["Picture"];
                    reader.Close();
                    return pic;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }
        }

        public bool AddNewRowDv(int id, string name, string brand, string type, string model, byte[] img)
        {
            string addCmd = "INSERT INTO Car (Id, Name, Brand, Type,Model, Picture) values (@val1, @val2, @val3, @val4, @val5, @val6)";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", id);
                comm.Parameters.AddWithValue("@val2", name);
                comm.Parameters.AddWithValue("@val3", brand);
                comm.Parameters.AddWithValue("@val4", type);
                comm.Parameters.AddWithValue("@val5", model);
                comm.Parameters.AddWithValue("@val6", img);
                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool RemoveRowDv(int id)
        {
            string addCmd = "DELETE FROM Car where Id = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", id);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool UpdateRowDv(int did, string name, string brand, string type, string model, byte[] img)
        {
            string addCmd = "update Car set Name = @val2,Brand = @val3, Type =  @val4, " +
                "Model = @val5, Picture = @val6 where Id = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", did);
                comm.Parameters.AddWithValue("@val2", name);
                comm.Parameters.AddWithValue("@val3", brand);
                comm.Parameters.AddWithValue("@val4", type);
                comm.Parameters.AddWithValue("@val5", model);
                comm.Parameters.AddWithValue("@val6", img);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public List<Dictionary<string, string>> FetchAllRowCl()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT MaKH,CCCD, TenKH, Loai, SoDT, DiaChi FROM KhachHang";

            SqlCommand command = new SqlCommand(sqlQuery, this.conn);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["MaKH"] = reader["MaKH"].ToString();
                    column["CCCD"] = reader["CCCD"].ToString();
                    column["TenKH"] = reader["TenKH"].ToString();
                    column["Loai"] = reader["Loai"].ToString();
                    column["SoDT"] = reader["SoDT"].ToString();
                    column["DiaChi"] = reader["DiaChi"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

        public bool AddNewRowCl(string name, string type, string phone, string adr, string CCCD)
        {
            string addCmd = "INSERT INTO KhachHang (TenKH,CCCD, Loai, SoDT, DiaChi) values (@val1, @val2, @val3, @val4, @val5)";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", name);
                comm.Parameters.AddWithValue("@val2", type);
                comm.Parameters.AddWithValue("@val3", phone);
                comm.Parameters.AddWithValue("@val4", adr);
                comm.Parameters.AddWithValue("@val5", CCCD);
                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool RemoveRowCl(string id)
        {
            string addCmd = "DELETE FROM KhachHang where MaKH = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", id);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool UpdateRowCl(string cid, string name, string type, string phone, string adr, string CCCD)
        {
            string addCmd = "update KhachHang set TenKH = @val2,CCCD=@val6, Loai = @val3, SoDT =  @val4, DiaChi = @val5 where MaKH = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", cid);
                comm.Parameters.AddWithValue("@val2", name);
                comm.Parameters.AddWithValue("@val3", type);
                comm.Parameters.AddWithValue("@val4", phone);
                comm.Parameters.AddWithValue("@val5", adr);
                comm.Parameters.AddWithValue("@val6", CCCD);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool UpdateQuantity(string cid)
        {
            string addCmd = "update SanPham set SoLuongTon = SoLuongTon - 1 where MaSP = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", cid);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public DataTable dataFromDB()
        {
            SqlCommand cmd = new SqlCommand("select MaSP, TenSP, DonGia, MoTaSP from SanPham", this.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public List<Dictionary<string, string>> FetchAllRowUr()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT TenDangNhap, MatKhau, PhanQuyen FROM DangNhap";

            SqlCommand command = new SqlCommand(sqlQuery, this.conn);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["TenDangNhap"] = reader["TenDangNhap"].ToString();
                    column["MatKhau"] = reader["MatKhau"].ToString();
                    column["PhanQuyen"] = reader["PhanQuyen"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

        public List<Dictionary<string, string>> FetchAllRowSu()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT ID, MaKH, Sdt, IdXe,NgayThue, NgayTra, Status,GhiChu FROM LT";

            SqlCommand command = new SqlCommand(sqlQuery, this.conn);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["ID"] = reader["ID"].ToString();
                    column["MaKH"] = reader["MaKH"].ToString();
                    column["Sdt"] = reader["Sdt"].ToString();
                    column["IdXe"] = reader["IdXe"].ToString();
                    column["NgayThue"] = reader["NgayThue"].ToString();
                    column["NgayTra"] = reader["NgayTra"].ToString();
                    column["Status"] = reader["Status"].ToString();
                    column["GhiChu"] = reader["GhiChu"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

        public bool AddNewRowSu(int id, int cusId, string phone,int idCar, DateTime dateNgayThue, DateTime dateNgayTra, string status, string ghiChu)
        {
            string addCmd = "INSERT INTO LT (ID, MaKH, Sdt, IdXe,NgayThue, NgayTra, Status,GhiChu) values (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8)";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", id);
                comm.Parameters.AddWithValue("@val2", cusId);
                comm.Parameters.AddWithValue("@val3", phone);
                comm.Parameters.AddWithValue("@val4", idCar);
                comm.Parameters.AddWithValue("@val5", dateNgayThue);
                comm.Parameters.AddWithValue("@val6", dateNgayTra);
                comm.Parameters.AddWithValue("@val7", status);
                comm.Parameters.AddWithValue("@val8", ghiChu);
                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool RemoveRowSu(string id)
        {
            string addCmd = "DELETE FROM LT where ID = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", id);

                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public bool UpdateRowSu(int sup, string phone, string adr , string box4, string text, DateTime dateTimePicker1, DateTime dateTimePicker3, string box1, string box5)
        {
            string addCmd = "update LT set MaKH=@val2, Sdt=@val3, IdXe=@val4,NgayThue=@val5, NgayTra=@val6, Status=@val7,GhiChu=@val8 where ID = @val1";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandText = addCmd;
                comm.Parameters.AddWithValue("@val1", sup);
                comm.Parameters.AddWithValue("@val2", phone);
                comm.Parameters.AddWithValue("@val3", adr);
                comm.Parameters.AddWithValue("@val4", box4);
                comm.Parameters.AddWithValue("@val5", dateTimePicker1);
                comm.Parameters.AddWithValue("@val6", dateTimePicker3);
                comm.Parameters.AddWithValue("@val7", box1);
                comm.Parameters.AddWithValue("@val8", box5);



                try
                {
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public List<Dictionary<string, string>> FetchRowSt()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT top(1) TongDoanhThu,ChiPhi FROM BaoCaoThongKe ORDER BY ThoiGianLap desc;";

            SqlCommand command = new SqlCommand(sqlQuery, this.conn);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {    //Every new row will create a new dictionary that holds the columns
                    column = new Dictionary<string, string>();

                    column["TongDoanhThu"] = reader["TongDoanhThu"].ToString();
                    column["ChiPhi"] = reader["ChiPhi"].ToString();
                    rows.Add(column); //Place the dictionary into the list
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //If an exception occurs, write it to the console
                Console.WriteLine(ex.ToString());
            }

            return rows;

        }

    }
}