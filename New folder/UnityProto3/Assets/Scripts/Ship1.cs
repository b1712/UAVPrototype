using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship1 : MonoBehaviour {

    int pitchCounter = 0;
    int rollCounter = 0;
    Helicopter1 heli;


    /// <summary>
    /// This is a test comment
    /// </summary>
    
    // Test again

    int i = 0;
    float y = 0;
    float x = 0;
    List<double> yValues;
    float pitchRotate = 0;
    //float rollRotate = 0;
    int timeLag = 30; //approx 2 secs

    void Start() {
        transform.position = new Vector3(0, 0, 0);
        
          

        //heli = gameObject.AddComponent<Helicopter1>();

        yValues = new List<double> {0.000000, 0.174497, 0.348782, 0.522642, 0.695866, 0.868241, 1.039558, 1.209609, 1.378187, 1.545085,
        1.710101, 1.873033, 2.033683, 2.191856, 2.347358, 2.500000, 2.649596, 2.795965, 2.938926, 3.078307,
        3.213938, 3.345653, 3.473292, 3.596699, 3.715724, 3.830222, 3.940054, 4.045085, 4.145188, 4.240240,
        4.330127, 4.414738, 4.493970, 4.567727, 4.635919, 4.698463, 4.755283, 4.806308, 4.851479, 4.890738,
        4.924039, 4.951340, 4.972609, 4.987820, 4.996954, 5.000000, 4.996954, 4.987820, 4.972609, 4.951340,
        4.924039, 4.890738, 4.851479, 4.806308, 4.755283, 4.698463, 4.635919, 4.567727, 4.493970, 4.414738,
        4.330127, 4.240240, 4.145188, 4.045085, 3.940054, 3.830222, 3.715724, 3.596699, 3.473292, 3.345653,
        3.213938, 3.078307, 2.938926, 2.795965, 2.649596, 2.500000, 2.347358, 2.191856, 2.033683, 1.873033,
        1.710101, 1.545085, 1.378187, 1.209609, 1.039558, 0.868241, 0.695866, 0.522642, 0.348782, 0.174497,
        0.000000, -0.174497, -0.348782, -0.522642, -0.695866, -0.868241, -1.039558, -1.209609, -1.378187, -1.545085,
        -1.710101, -1.873033, -2.033683, -2.191856, -2.347358, -2.500000, -2.649596, -2.795965, -2.938926, -3.078307,
        -3.213938, -3.345653, -3.473292, -3.596699, -3.715724, -3.830222, -3.940054, -4.045085, -4.145188, -4.240240,
        -4.330127, -4.414738, -4.493970, -4.567727, -4.635919, -4.698463, -4.755283, -4.806308, -4.851479, -4.890738,
        -4.924039, -4.951340, -4.972609, -4.987820, -4.996954, -5.000000, -4.996954, -4.987820, -4.972609, -4.951340,
        -4.924039, -4.890738, -4.851479, -4.806308, -4.755283, -4.698463, -4.635919, -4.567727, -4.493970, -4.414738,
        -4.330127, -4.240240, -4.145188, -4.045085, -3.940054, -3.830222, -3.715724, -3.596699, -3.473292, -3.345653,
        -3.213938, -3.078307, -2.938926, -2.795965, -2.649596, -2.500000, -2.347358, -2.191856, -2.033683, -1.873033, 
        -1.710101, -1.545085, -1.378187, -1.209609, -1.039558, -0.868241, -0.695866, -0.522642, -0.348782, -0.174497};

        //heli.Start();
        
        //yValues = new List<double>();
        //float freq = 1 / 6;
        //float twoPiFreq = 2 * Mathf.PI * freq;
        //float amp = 5.0f;

        //for (int i = 0; i < 180; i++)
        //{
        //    yValues.Add((double)amp * (Mathf.Sin((float)twoPiFreq * ((float)i / 30.0f))));

        //    double p = amp * (Mathf.Sin((float)twoPiFreq * ((float)i / 30.0f)));
        //    print(p.ToString());

        //    //print(yValues[i].ToString());
        //}


    }

    void Update()
    {
        var poz = new Vector3(-150, 65, -20);
        Instantiate(heli, poz, Quaternion.identity);
        i++;

        //print("i= " + i + " mod i= " + (i % 2));

        if (i % 3 == 0)
        {
            subMethodPitch();
        }

        if (i % 6 == 0)
        {
            //subMethodRoll();
            rollCounter++;
        }

        heli.Update();
    }

    void subMethodPitch()
    {
        pitchCounter++;

        //print("counter= " + counter);
        //y=amplitude * sin(frequency * time + phase) + bias

        //2 * Mathf.PI * (1/6) * ((float)(counter % 30) + 1) / 30

        //float y = 5.0f * Mathf.Sin(2.0f * Mathf.PI * (1.0f / 6.0f) * (float)((counter % 30) + 1) / 30.0f);
        ////float q = 2.0f * Mathf.PI * (1.0f / 6.0f) * (float)((counter % 30) + 1) / 30.0f;
        //print("counter= " + y);

        y = (float)(yValues[pitchCounter%180]);

        gameObject.transform.position = new Vector3(0, y, 0);
        //yRotate = y - yRotate;
        if (((pitchCounter - timeLag) % 180) >= 0)
        {
            pitchRotate = -(float)(yValues[(pitchCounter - timeLag) % 180]) / 2.0f;
            x = -(float)(yValues[rollCounter % 180]) * 2.0f;
            //print(yRotate + " = " + y + " - " + yRotate);
            //rollRotate = -(float)(yValues[(counter - timeLag) % 180]) / 2.0f;
            gameObject.transform.eulerAngles = new Vector3(x, 0, pitchRotate);
            //gameObject.transform.eulerAngles = new Vector3(0, 0, pitchRotate);
        }

        Vector3 point = gameObject.transform.position;
        print(point.x + ", " + point.y + ", " + point.z);


        //gameObject.transform.Rotate(0, 0, yRotate);
    }


    void subMethodRoll()
    {
        
    }
}

