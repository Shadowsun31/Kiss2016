using UnityEngine;
using System.Collections;

public class Migrant : MonoBehaviour {

    
    public GameObject head;
    public GameObject body;
    public GameObject leftarm;
    public GameObject lefthand;
    public GameObject rightarm;
    public GameObject righthand;
    public GameObject leftleg;
    public GameObject leftfoot;
    public GameObject rightleg;
    public GameObject rightfoot;

    public Sprite[] headSprite;
    public Sprite[] bodySprite;
    public Sprite[] leftarmSprite;
    public Sprite[] lefthandSprite;
    public Sprite[] rightarmSprite;
    public Sprite[] righthandSprite;
    public Sprite[] leftlegSprite;
    public Sprite[] leftfootSprite;
    public Sprite[] rightlegSprite;
    public Sprite[] rightfootSprite;

    protected bool pressJump = false;
    protected float direction = 0;

    private bool plouf = false;

    [SerializeField]
    private float jump;

    [SerializeField]
    protected float deplacement;


    [SerializeField]
    private new Rigidbody2D rigidbody2D;

    private bool isJumping = false;
    


    public virtual void Update()
    {

        if (pressJump)
        {
            if (!isJumping)
            {
                isJumping = true;
                StartCoroutine(jumpIenum());
            }
        }

        rigidbody2D.AddForce(new Vector2(direction * deplacement * Time.deltaTime, 0), ForceMode2D.Force);

    }

    public IEnumerator jumpIenum()
    {
        rigidbody2D.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        yield return new WaitForSeconds(1);
        isJumping = false;

    }



    public virtual void Start()
    {
        int headIndex = Random.Range(0, headSprite.Length);
        int bodyIndex = Random.Range(0, bodySprite.Length);
        int legsIndex = Random.Range(0, leftlegSprite.Length);

        head.GetComponentInChildren<SpriteRenderer>().sprite = headSprite[headIndex];
        body.GetComponentInChildren<SpriteRenderer>().sprite = bodySprite[bodyIndex];
        leftarm.GetComponentInChildren<SpriteRenderer>().sprite = leftarmSprite[bodyIndex];
        lefthand.GetComponentInChildren<SpriteRenderer>().sprite = lefthandSprite[bodyIndex];
        rightarm.GetComponentInChildren<SpriteRenderer>().sprite = rightarmSprite[bodyIndex];
        righthand.GetComponentInChildren<SpriteRenderer>().sprite = righthandSprite[bodyIndex];
        leftleg.GetComponentInChildren<SpriteRenderer>().sprite = leftlegSprite[legsIndex];
        leftfoot.GetComponentInChildren<SpriteRenderer>().sprite = leftfootSprite[legsIndex];
        rightleg.GetComponentInChildren<SpriteRenderer>().sprite = rightlegSprite[legsIndex];
        rightfoot.GetComponentInChildren<SpriteRenderer>().sprite = rightfootSprite[legsIndex];

        GameObject[] bodyParts = new GameObject[] { head, body, leftarm, lefthand, rightarm, righthand, leftleg, leftfoot, rightleg, rightfoot };
        Collider2D[] colliderParts = new Collider2D[bodyParts.Length];
        for (int i = 0; i < bodyParts.Length; i++)
        {
            colliderParts[i] = bodyParts[i].GetComponent<Collider2D>();
        }
        for (int i = 0;i< bodyParts.Length; i++)
        {
            for(int j = i+1;j < bodyParts.Length; j++)
            {
                Physics2D.IgnoreCollision(colliderParts[i], colliderParts[j]);
            }
        }

    }

    public virtual void Die()
    {
        GameData.singleton.nbrDeadMigrant++;
        if( !plouf )
        {
            plouf = true;
            S_AudioManager.singleton.PlayPlouf();
        }
       
    }
}
