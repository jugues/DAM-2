package com.example.empleadosparcelable;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    Activity contexto;
    private Button btnEnviar;
    private EditText etNombre, etEdad;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        contexto = this;
        btnEnviar = findViewById(R.id.btnEnviar);
        etNombre = findViewById(R.id.etNombre);
        etEdad = findViewById(R.id.etEdad);

        btnEnviar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Empleado emple = new Empleado(etNombre.getText().toString(), Integer.parseInt(etEdad.getText().toString()));
                Intent intent = new Intent(contexto, MostrarDatos.class);
                Log.e("Info del empleado: ", emple.getNombre());
                //intent.putExtra("nombre", etNombre.getText().toString());
                //intent.putExtra("edad", Integer.parseInt(etEdad.getText().toString()));
                intent.putExtra("empleado", emple);
                startActivity(intent);
            }
        });

    }
}