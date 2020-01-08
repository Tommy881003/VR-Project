using UnityEngine;

public class Avatar : MonoBehaviour {

	public ParticleSystem shape, trail, burst;

	private Player player;
    public bool die = false;
	public float deathCountdown = -1f;

	private void Awake () {
		player = transform.root.GetComponent<Player>();
        die = false;
	}

	private void OnTriggerEnter (Collider collider) {
        die = true;
        /*if (deathCountdown < 0f) {
			shape.enableEmission = false;
			trail.enableEmission = false;
			burst.Emit(burst.maxParticles);
			deathCountdown = burst.startLifetime;
		}*/
	}
	
	private void Update () {
        if(die)
        {
            player.Die();
            die = false;
        }
        /*if (deathCountdown >= 0f) {
			deathCountdown -= Time.deltaTime;
			if (deathCountdown <= 0f) {
				deathCountdown = -1f;
				shape.enableEmission = true;
				trail.enableEmission = true;
				player.Die();
			}
		}*/
    }
}