package com.example.ejemplospinner;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.Spinner;

public class MainActivity extends AppCompatActivity {

    private ImageView imgvAnimal;
    private Spinner spAnimal;
    private Spinner spAnimal2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        spAnimal = (Spinner) findViewById(R.id.spAnimal);
        spAnimal2 = (Spinner) findViewById(R.id.spAnimal2);
        imgvAnimal = (ImageView) findViewById(R.id.imgvAnimal);

        String [] animales = {"león","águila","tigre"};
        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(getApplicationContext(), R.layout.support_simple_spinner_dropdown_item, animales); //contexto, layout y array
        spAnimal.setAdapter(arrayAdapter);

        String [] animalesOtros = {"pato","puma","delfín"};
        ArrayAdapter<String> arrayAdapter2 = new ArrayAdapter<String>(getApplicationContext(), R.layout.mi_item_layout, R.id.tvLay, animalesOtros);
        spAnimal2.setAdapter(arrayAdapter2);
    }
}