using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
    public GameObject ball;
    public Vector3 destination;
    public float waitTime;
    public Ball ballMachine;

    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        destination = ball.transform.position;
        StartCoroutine(MoveParticles());

        if(ballMachine.currentState == ballState.red)
        {
            var main = ps.main;
            main.startColor = new ParticleSystem.MinMaxGradient(Color.red);
        }

        else if(ballMachine.currentState == ballState.blue)
        {
            var main = ps.main;
            main.startColor = new ParticleSystem.MinMaxGradient(Color.blue);
        }

        else if (ballMachine.currentState == ballState.green)
        {
            var main = ps.main;
            main.startColor = new ParticleSystem.MinMaxGradient(Color.green);
        }
    }

    private IEnumerator MoveParticles()
    {
        yield return new WaitForSeconds(waitTime);
        transform.position = destination;
        yield return null;

    }
}
