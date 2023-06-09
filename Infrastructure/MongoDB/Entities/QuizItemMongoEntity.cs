﻿using ApplicationCore.Models;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MongoDB.Entities
{
    public class QuizItemMongoEntity
    {
        [BsonElement("id")]
        public int ItemId { get; set; }

        [BsonElement("question")]
        public string Question { get; set; }

        [BsonElement("incorrectAnswers")]
        public List<string> IncorrectAnswers { get; set; }

        [BsonElement("correctAnswer")]
        public string CorrectAnswer { get; set; }

        /*public IQueryable<QuizItem> FromMongoToQuiz2(this IQuearable<QuizItemMongoEntity> quizItem)
        {
            return quizItem.Select(i => new QuizItem
            {
                quizItem.ItemId,
                quizItem.Question,
                quizItem.IncorrectAnswer,
            })
        }*/
        public QuizItem FromMongoToQuiz(QuizItemMongoEntity quizItem)
        {
            return new QuizItem(
                quizItem.ItemId,
                quizItem.Question,
                quizItem.IncorrectAnswers,
                quizItem.CorrectAnswer
                );
        }
    }
}
