package com.example.evaluadornotas;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private EditText etFisica, etQuimica, etMates;
    private Button btnCalcular;
    TextView tv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etFisica = findViewById(R.id.etFisica);
        etQuimica = findViewById(R.id.etQuimica);
        etMates = findViewById(R.id.etMates);
        btnCalcular = findViewById(R.id.btnCalcular);
        tv = findViewById(R.id.tvResul);

        btnCalcular.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                calcular();
            }
        });
    }

    private void calcular()
    {
        int valorFisica = Integer.parseInt(etFisica.getText().toString());
        int valorQuimica = Integer.parseInt(etQuimica.getText().toString());
        int valorMates = Integer.parseInt(etMates.getText().toString());
        int result = (valorFisica + valorQuimica + valorMates) / 3;
        String resul = "";
        if(result > 5)
        {
            resul = "Has aprobado con un " + result;
        }

        else
        {
            resul = "Has suspendido con un " + result;
        }

        tv.setText(resul);
        etFisica.setText("");
        etQuimica.setText("");
        etMates.setText("");
    }
}