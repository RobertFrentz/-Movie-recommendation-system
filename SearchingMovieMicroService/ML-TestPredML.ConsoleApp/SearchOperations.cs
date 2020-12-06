using System;
using System.Collections.Generic;
using System.Linq;
using ML_TestPredML.Model;

namespace ML_TestPredML.ConsoleApp
{
    public class SearchOperations
    {
        public static float Prediction(ModelInput data)
        {
            var predictionResult = ConsumeModel.Predict(data);
            return predictionResult.Score;
        }

        public static List<float> RecommendedMoviesIdByCategory(float userId, string category)
        {

            List<float> moviesId = CSVParser.ImportMovieFromCategorySpecified(category);
            SortedList<float, float> predictions = new SortedList<float, float>();
            for (int i = 0; i < 15; i++)
            {
                ModelInput data = new ModelInput()
                {
                    UserId = userId,
                    MovieId = moviesId[i],
                };
                float predict = Prediction(data);
                if (!predictions.ContainsKey(moviesId[i]))
                {
                    predictions.Add(moviesId[i], predict);
                }
            }
            var sortedPredictions = predictions.OrderBy(r => r.Value);
            moviesId.Clear();
            foreach (KeyValuePair<float, float> prediction in sortedPredictions)
            {
                moviesId.Add(prediction.Key);
            }
            return moviesId;
        }

        public static List<float> RecommendMoviesIdByKeyword(float userId, string keyword)
        {
            List<float> moviesIdRecommendedUsingTag = RecommendedMoviesIdByTag(userId, keyword);
            List<float> moviesIdRecommendedUsingTitle = RecommendedMoviesIdByTitle(userId, keyword);
            List<float> finalMoviesId = new List<float>();
            Random random = new Random();
            for(int i = 0; i < 15; i++)
            {
                int randomNumber = random.Next(2);
                if(randomNumber == 0)
                {
                    if(moviesIdRecommendedUsingTag != null && moviesIdRecommendedUsingTag.Count > i)
                    {
                        finalMoviesId.Add(moviesIdRecommendedUsingTag[i]);
                    }
                    else
                    {
                        if(moviesIdRecommendedUsingTitle != null && moviesIdRecommendedUsingTitle.Count > i)
                        {
                            finalMoviesId.Add(moviesIdRecommendedUsingTitle[i]);
                        }
            
                    }
                    
                } else
                {
                    if(moviesIdRecommendedUsingTitle != null && moviesIdRecommendedUsingTitle.Count > i)
                    {
                        finalMoviesId.Add(moviesIdRecommendedUsingTitle[i]);
                    }
                    else
                    {
                        if(moviesIdRecommendedUsingTag != null && moviesIdRecommendedUsingTag.Count > i)
                        {
                            finalMoviesId.Add(moviesIdRecommendedUsingTag[i]);
                        }
                        
                    }

                }
            }
            return finalMoviesId;
        }

        public static List<float> RecommendedMoviesIdByTag(float userId, string tag)
        {

            List<float> moviesId = CSVParser.ImportMovieFromTagSpecified(tag);
            if(moviesId.Count < 15)
            {
                return null;
            }
            SortedList<float, float> predictions = new SortedList<float, float>();
            for (int i = 0; i < 15; i++)
            {
                ModelInput data = new ModelInput()
                {
                    UserId = userId,
                    MovieId = moviesId[i],
                };
                float predict = Prediction(data);
                if (!predictions.ContainsKey(moviesId[i]))
                {
                    predictions.Add(moviesId[i], predict);
                }
            }
            var sortedPredictions = predictions.OrderBy(r => r.Value);
            moviesId.Clear();
            foreach (KeyValuePair<float, float> prediction in sortedPredictions)
            {
                moviesId.Add(prediction.Key);
            }
            return moviesId;

        }
        public static List<float> RecommendedMoviesIdByTitle(float userId, string title)
        {

            List<float> moviesId = CSVParser.ImportMovieFromTitleSpecified(title);
            if(moviesId.Count < 15)
            {
                return null;
            }
            SortedList<float, float> predictions = new SortedList<float, float>();
            for (int i = 0; i < 15; i++)
            {
                ModelInput data = new ModelInput()
                {
                    UserId = userId,
                    MovieId = moviesId[i],
                };
                float predict = Prediction(data);
                if (!predictions.ContainsKey(moviesId[i]))
                {
                    predictions.Add(moviesId[i], predict);
                }
            }
            var sortedPredictions = predictions.OrderBy(r => r.Value);
            moviesId.Clear();
            foreach (KeyValuePair<float, float> prediction in sortedPredictions)
            {
                moviesId.Add(prediction.Key);
            }
            return moviesId;
        }
    }
}
