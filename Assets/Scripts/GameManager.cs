using UnityEngine;

public static class GameManager
{
    private static int _score = 0;
    private static int _lives = 3;

    public static void AddLives(int value)
    {
        _lives += value;
        if (_lives <= 0)
        {
            Debug.Log("Game Over");
            _lives = 0;
        }

        Debug.Log("Lives = " + _lives);
    }

    public static void AddScore(int value)
    {
        _score += value;
        Debug.Log("Score = " + _score);
    }
}