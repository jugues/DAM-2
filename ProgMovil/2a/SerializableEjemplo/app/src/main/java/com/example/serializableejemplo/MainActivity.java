package com.example.serializableejemplo;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.Adapter;
import android.widget.ListView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    private ListView lvItems;
    private Adaptador adapt;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        lvItems = findViewById(R.id.lvItems);
        ArrayList<Elemento> miListaItems;
        miListaItems = new ArrayList<>();
        miListaItems.add(new Elemento(R.drawable.el_gustavo, "El tripas", "El mayor luchador"));
        miListaItems.add(new Elemento(R.drawable.el_rufo, "El rufo", "El hombre más elástico de la historia"));
        miListaItems.add(new Elemento(R.drawable.se_peina, "El melenas", "Se peina"));
        adapt = new Adaptador(this, miListaItems);
        lvItems.setAdapter(adapt);



    }
}