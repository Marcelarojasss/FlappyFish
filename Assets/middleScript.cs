using UnityEngine;

public class middleScript : MonoBehaviour
{
    public LogicScript logic; // Reference to LogicScript

    // Start is called before the first frame
    void Start()
    {
        // Find the GameObject tagged "Logic" and get the LogicScript component
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        if (logic == null)
        {
            Debug.LogError("LogicScript not found! Make sure the Logic object has the 'Logic' tag and the LogicScript component.");
        }
    }

    // Trigger detection when another collider enters this trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (logic != null)
        {
            logic.addScore(1); // Pass the score value to add (e.g., 1 point)
        }
    }
}

