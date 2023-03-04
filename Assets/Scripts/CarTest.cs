using UnityEngine;

// INHERITANCE
public class Vehicle
{
    public string brand;
    public int year;

    public virtual void StartEngine()
    {
        Debug.Log("Generic vehicle engine sound");
    }
}

public class Car : Vehicle
{
    public void Honk()
    {
        Debug.Log("Beep beep!");
    }

    // POLYMORPHISM
    public override void StartEngine()
    {
        Debug.Log("Vroom vroom!");
    }

    // ENCAPSULATION
    private float speed;
    public float Speed
    {
        get { return speed; }
        set
        {
            if (value >= 0f)
            {
                speed = value;
            }
        }
    }

    // ABSTRACTION
    public void Drive()
    {
        Debug.Log("The car is driving.");
        // Details of how the car is driving are abstracted away.
    }
}

public class CarTest : MonoBehaviour
{
    void Start()
    {
        Car car = new Car();
        car.brand = "Toyota";
        car.year = 2022;
        car.Speed = 60f;
        Debug.Log("Brand: " + car.brand + ", Year: " + car.year + ", Speed: " + car.Speed + " mph");
        car.Honk();
        car.StartEngine();
        car.Drive();
    }
}
