package com.example.restaurante;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.TextView;

import org.w3c.dom.Text;

public class MainActivity extends AppCompatActivity {

    CheckBox chkQueso;
    CheckBox chkBacon;
    CheckBox chkPepino;
    private float precioTotal;
    private TextView tv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        precioTotal = 0;

        chkQueso = (CheckBox) findViewById(R.id.chkQueso);
        chkPepino = (CheckBox) findViewById(R.id.chkPepino);
        chkBacon = (CheckBox) findViewById(R.id.chkBacon);
        tv = (TextView) findViewById(R.id.tvPrecioTotal);

    }

    public void seleccionar(View v)
    {
        switch (v.getId()) {
            case R.id.chkPepino:
                if (((CheckBox) v).isChecked()) {
                    precioTotal += 0.25;
                } else {
                    precioTotal -= 0.25;
                }
                break;
            case R.id.chkBacon:
                if (((CheckBox) v).isChecked()) {
                    precioTotal += 0.35;
                } else {
                    precioTotal -= 0.35;
                }
                break;
            case R.id.chkQueso:
                if (((CheckBox) v).isChecked()) {
                    precioTotal += 0.15;
                } else {
                    precioTotal -= 0.15;
                }
                break;

        }

        tv.setText("Total: " + precioTotal + "€");
    }
}