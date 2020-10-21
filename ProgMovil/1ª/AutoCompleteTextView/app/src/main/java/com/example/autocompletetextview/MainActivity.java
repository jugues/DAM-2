package com.example.autocompletetextview;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;

public class MainActivity extends AppCompatActivity {

    private static final String[] paises = {"Portugal", "Francia", "Alemania", "Austria"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        AutoCompleteTextView acTV;
        acTV = (AutoCompleteTextView) findViewById(R.id.acTV);
        acTV.setThreshold(1);

        //desplegable
        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_dropdown_item_1line, paises);
        acTV.setAdapter(arrayAdapter);
    }
}