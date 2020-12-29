package com.example.calculadorasimple;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private EditText et1, et2;
    private Button btn;
    private TextView tv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        et1 = findViewById(R.id.et1);
        et2 = findViewById(R.id.et2);
        btn = findViewById(R.id.btnCalcular);
        tv = findViewById(R.id.tvResult);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                sumar();
            }
        });
    }

    public void sumar()
    {
        int valor1 = Integer.parseInt(et1.getText().toString());
        int valor2 = Integer.parseInt(et2.getText().toString());
        int suma = valor1 + valor2;
        String resul = String.valueOf(suma);
        tv.setText(resul);
        et1.setText("");
        et2.setText("");
    }
}