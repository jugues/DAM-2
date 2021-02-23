package com.example.empleadosparcelable;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

public class MostrarDatos extends AppCompatActivity {

    private TextView tvNombre, tvEdad;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mostrar_datos);

        tvNombre = findViewById(R.id.tvNombre);
        tvEdad = findViewById(R.id.tvEdad);

        Intent i = this.getIntent();
        Empleado empleado = i.getParcelableExtra("emple");

        try {

            tvNombre.setText("Nombre: " + empleado.getNombre());
            tvEdad.setText("Edad: " + empleado.getEdad());
        }
        catch(NullPointerException e)
        {
            e.printStackTrace();
        }

    }
}