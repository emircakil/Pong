using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMove ballMove;
    public ScoreController scoreController;

    void BounceFromRocket(Collision2D c) {

        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosiiton = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;

        float x;

        if (c.gameObject.name == "RacketPlayer1")
        {

            x = 1;
        }
        else {
            x = -1;
        }

        float y = (ballPosition.y - racketPosiiton.y)/ (racketHight);

        this.ballMove.IncreaseHitCounter();
        this.ballMove.MoveBall(new Vector2(x, y));
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRocket(collision);

        }
        else if (collision.gameObject.name == "WallLeft")
        {

            Debug.Log("WallLeft");
            scoreController.GoalPlayer2();
            StartCoroutine(this.ballMove.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight") {

            Debug.Log("WallRight");
            scoreController.GoalPlayer1();
            StartCoroutine(this.ballMove.StartBall(false));

        }
    }

}
