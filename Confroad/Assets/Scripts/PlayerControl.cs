using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    
    public float speed;
    public Text countText;
    public Button btn_PlayAgain;
    public bool coins = false;

    private Rigidbody rb;
    public int count;
    public bool canRoll = false;

    void Awake()
    {
        SetDefaults();
    }

    void SetDefaults()
    {
        SettingsSingleton.Instance.speed = speed;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();      
    }

    void FixedUpdate()
    {
        if (canRoll)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString() + " / 21";
    }
}
