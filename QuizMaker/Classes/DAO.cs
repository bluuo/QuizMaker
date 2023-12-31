﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static QuizMaker.DAO;
using static QuizMaker.Helper;

namespace QuizMaker
{
    class DAO
    {
        private static string relativePath = "..\\..\\Database.mdf";
        private static string absolutePath = Path.GetFullPath(relativePath);
        private string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={absolutePath};Integrated Security=True";

        private static DAO instance;

        public static DAO GetInstance()
        {
            if (instance == null)
                instance = new DAO();

            return instance;
        }
        public List<Question> getAllQuestions()
        {
            List<Question> questionList = new List<Question>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM QuestionsTable"; // Replace with your actual table name

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve values for each row
                            Question question = new Question
                            {
                                Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                Category = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                QuestionText = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                CorrectAnswer = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                WrongAnswer1 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                                WrongAnswer2 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                                WrongAnswer3 = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                            };
                            questionList.Add(question);
                        }
                    }
                }
            }
            return questionList;
        }

        public List<Question> getQuestionsForQuiz(string name, string category, int size)
        {
            List<Question> selectedQuestions = new List<Question>();
            List<Question> filteredQuestions = new List<Question>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;
                if (string.IsNullOrEmpty(category))
                    query = "SELECT * FROM QuestionsTable";
                else
                    query = "SELECT * FROM QuestionsTable WHERE category LIKE '" + category + "'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve values for each row
                            Question question = new Question
                            {
                                Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                Category = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                QuestionText = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                CorrectAnswer = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                WrongAnswer1 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                                WrongAnswer2 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                                WrongAnswer3 = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                            };
                            selectedQuestions.Add(question);
                        }
                    }
                }
            }
            filteredQuestions = selectedQuestions.Take(size).ToList();
            return filteredQuestions;
        }
        public void insertQuestion(Question question)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText =
                "Insert into QuestionsTable(category, question, answer_correct, answer_wrong1, answer_wrong2, answer_wrong3) " +
                "VALUES ('" + question.Category + "', '" + question.QuestionText + "', '" + question.CorrectAnswer + "', '" + question.WrongAnswer1 + "', '" + question.WrongAnswer2 + "', '" + question.WrongAnswer3 + "')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void deleteQuestion(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "DELETE from QuestionsTable where id =" + id;
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Question getSingleQuestion(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from QuestionsTable where id =" + id.ToString();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Question question = new Question
                            {
                                Id = reader.GetInt32(0),
                                Category = reader.GetString(1),
                                QuestionText = reader.GetString(2),
                                CorrectAnswer = reader.GetString(3),
                                WrongAnswer1 = reader.GetString(4),
                                WrongAnswer2 = reader.GetString(5),
                                WrongAnswer3 = reader.GetString(6)
                            };

                            return question;
                        }
                    }
                }
            }
            return null;
        }

        public List<Quiz> getAllQuizzes()
        {
            List<Quiz> quizList = new List<Quiz>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM QuizzesTable"; // Replace with your actual table name

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve values for each row
                            Quiz quiz = new Quiz
                            {
                                Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                Category = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                Size = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                            };
                            quizList.Add(quiz);
                        }
                    }
                }
            }
            return quizList;
        }

        public Quiz getSingleQuiz(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * from QuizzesTable where id =" + id.ToString();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Quiz quiz = new Quiz
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Category = reader.GetString(2),
                                Size = reader.GetInt32(3)
                            };

                            return quiz;
                        }
                    }
                }
            }
            return null;
        }

        public void insertQuiz(Quiz quiz)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText =
                "Insert into QuizzesTable(name, category, size) " +
                "VALUES ('" + quiz.Name + "', '" + quiz.Category + "', '" + quiz.Size + "')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void deleteQuiz(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "DELETE from QuizzesTable where id =" + id;
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
