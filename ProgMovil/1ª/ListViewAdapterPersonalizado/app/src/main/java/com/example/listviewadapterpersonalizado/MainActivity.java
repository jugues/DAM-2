package com.example.listviewadapterpersonalizado;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    private ListView lv;
    private Adapter adaptador;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ArrayList<Persona> personas = new ArrayList<Persona>();

        personas.add(new Persona(1, "Preparao", "Tu rey", R.drawable.felipe));
        personas.add(new Persona(2, "Miguelito", "Si te sumba el oído te oyen los aliens", R.drawable.miguel));
        personas.add(new Persona(3, "Willy", "El chino", R.drawable.willy));

        adaptador = new Adaptador(getApplicationContext(), personas);
        lv = (ListView) findViewById(R.id.lv);
        lv.setAdapter((ListAdapter) adaptador);

        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Persona persona = (Persona) adaptador.getItem(position);
                Toast.makeText(getBaseContext(), "El código es " + persona.getCod(), Toast.LENGTH_SHORT).show();
            }
        });

    }
}