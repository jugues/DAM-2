package com.example.segundaapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    TextView tv;
    Button btnColor;
    LinearLayout layoutPrincipal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tv = (TextView)findViewById(R.id.tvCajita);
        layoutPrincipal = (LinearLayout)findViewById(R.id.layoutPrincipal);
        btnColor = (Button)findViewById(R.id.btnColor);
        btnColor.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                tv.setTextColor(getResources().getColor(R.color.colorAccent));
                layoutPrincipal.setBackgroundColor(getResources().getColor(R.color.naranjita));
            }
        });
    }

    public void agrandar(View view)//ampliar el tamaño del text view
    {
        tv.setTextSize(30);
    }
}