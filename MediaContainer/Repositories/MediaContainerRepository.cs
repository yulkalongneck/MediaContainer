using MediaContainer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MediaContainer.Repositories
{
    public class MediaContainerRepository
    {
        //PLaylist fucntions
        public List<Playlist> CreatePlaylists(List<Playlist> playlists)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            List<Playlist> _playlists = new List<Playlist>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_CreatePlaylists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@Playlists", JsonConvert.SerializeObject(playlists));
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _playlists = JsonConvert.DeserializeObject<List<Playlist>>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _playlists;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Playlist> UpdatePlaylists(List<Playlist> playlists)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            List<Playlist> _playlists = new List<Playlist>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_UpdatePlaylists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@Playlists", JsonConvert.SerializeObject(playlists));
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _playlists = JsonConvert.DeserializeObject<List<Playlist>>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _playlists;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Playlist> GetPlaylists(int userID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            List<Playlist> _playlists = new List<Playlist>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_GetPlaylists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@userID", userID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _playlists = JsonConvert.DeserializeObject<List<Playlist>>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _playlists;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Playlist GetPlaylist(int ID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            Playlist _playlist = new Playlist();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_GetPlaylist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _playlist = JsonConvert.DeserializeObject<Playlist>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _playlist;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Playlist DeletePlaylist(int ID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            Playlist _playlist = new Playlist();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_DeletePlaylist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _playlist = JsonConvert.DeserializeObject<Playlist>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _playlist;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        //Folder functions
        public List<Folder> CreateFolders(List<Folder> folders)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            List<Folder> _folders = new List<Folder>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_CreateFolders", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@Folders", JsonConvert.SerializeObject(folders));
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _folders = JsonConvert.DeserializeObject<List<Folder>>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _folders;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Folder> UpdateFolders(List<Folder> folders)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            List<Folder> _folders = new List<Folder>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_UpdatePlaylists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@Folders", JsonConvert.SerializeObject(folders));
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _folders = JsonConvert.DeserializeObject<List<Folder>>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _folders;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Folder> GetFolders(int userID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            List<Folder> _folders = new List<Folder>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_GetFolders", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@userID", userID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _folders = JsonConvert.DeserializeObject<List<Folder>>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _folders;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Folder GetFolder(int ID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            Folder _folder = new Folder();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_GetFolder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _folder = JsonConvert.DeserializeObject<Folder>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _folder;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Folder DeleteFolder(int ID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            Folder _folder = new Folder();
            try
            {
                using (SqlCommand cmd = new SqlCommand("MediaContainer_p_DeleteFolder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // pass a list of objects as a json (SQL 2016)
                    cmd.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["JsonResponse"] != DBNull.Value)
                                {
                                    _folder = JsonConvert.DeserializeObject<Folder>(reader["JsonResponse"].ToString());
                                }
                            }
                        }

                    }
                    conn.Close();
                }
                return _folder;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}