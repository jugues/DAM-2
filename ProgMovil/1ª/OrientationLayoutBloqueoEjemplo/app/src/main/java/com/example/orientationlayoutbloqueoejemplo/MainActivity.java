package com.example.orientationlayoutbloqueoejemplo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.pm.ActivityInfo;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private Button btnHorizontal, btnVertical, btnAutomatico;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnHorizontal = (Button) findViewById(R.id.btnHorizontal);
        btnVertical = (Button) findViewById(R.id.btnVertical);
        btnAutomatico = (Button) findViewById(R.id.btnAutomatico);

        btnHorizontal.setOnClickListener(this);
        btnVertical.setOnClickListener(this);
        btnAutomatico.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {

        switch(v.getId())
        {
            case R.id.btnHorizontal:
                Toast.makeText(getApplicationContext(), "Orientación horizontal", Toast.LENGTH_LONG).show();
                setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_LANDSCAPE);
                break;
            case R.id.btnVertical:
                Toast.makeText(getApplicationContext(), "Orientación vertical", Toast.LENGTH_LONG);
                setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_PORTRAIT);
                break;
            case R.id.btnAutomatico:Toast.makeText(getApplicationContext(), "Orientación automática", Toast.LENGTH_LONG);
                setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_SENSOR);
                break;

        }

    }
}