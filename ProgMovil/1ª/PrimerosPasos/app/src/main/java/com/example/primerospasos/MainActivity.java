package com.example.primerospasos;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    TextView tv;
    Button btnCambiarAzul, btnCambiarVerde, btnCambiarAmarillo;
    LinearLayout ly;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tv = (TextView)findViewById(R.id.tv);
        btnCambiarAzul = (Button)findViewById(R.id.btnColorAzul);
        ly = (LinearLayout)findViewById(R.id.layoutPrincipal);
        btnCambiarAmarillo = (Button)findViewById(R.id.btnColorAmarillo);
        btnCambiarVerde = (Button)findViewById(R.id.btnColorVerde);

        btnCambiarVerde.setOnClickListener(this);
        btnCambiarAmarillo.setOnClickListener(this);
        btnCambiarAzul.setOnClickListener(this);
        /* btnColor.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                tv.setTextColor(getResources().getColor(R.color.colorAccent));
                ly.setBackgroundColor(getResources().getColor(R.color.colorPrimaryDark));
            }
        }); */
    }

    /* public void agrandar(View view)
    {
        tv.setTextSize(30);

    } */

    @Override
    public void onClick(View v) {

        if(v.getId() == R.id.btnColorAzul)
        {
            tv.setTextColor(getResources().getColor(R.color.colorAccent));
            ly.setBackgroundColor(getResources().getColor(R.color.colorPrimaryDark));
        }

        if(v.getId() == R.id.btnColorVerde)
        {
            ly.setBackgroundColor(Color.GREEN);
        }

        if(v.getId() == R.id.btnColorAmarillo)
        {
            ly.setBackgroundColor(Color.YELLOW);
        }

    }
}