package com.example.listviewstrings;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import java.lang.reflect.Array;

public class MainActivity extends AppCompatActivity {

    private String [] nombres = {"Pedro","Juan","Ana","Julián","Marcos","Marc","Max","Izan","Jori","Trabajo","Casa", "Mamá", "Papá", "Jesús","Adrián"};
    private String[] numeros = {"6467454565","9456695656","455654675","6354656757","456757567657","6467454565","9456695656","999999999999","4356667666","254566666666","6454675768795","9456695656","455654675","567657786875","654689577649"};
    private String[] sexo = {"V","V","M","V","V","V","V","V","M","X","X", "M", "V", "V","V"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ListView lv = (ListView) findViewById(R.id.lv);
        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(getApplicationContext(), R.layout.support_simple_spinner_dropdown_item, nombres);
        lv.setAdapter(arrayAdapter);

        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {

                Toast.makeText(getApplicationContext(),"El teléfono de " + nombres[position] + " es " + numeros[position], Toast.LENGTH_SHORT).show();
            }
        });

        lv.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
                Toast.makeText(getApplicationContext(),"El sexo de " + nombres[position] + " es " + sexo[position], Toast.LENGTH_SHORT).show();
                return true; //con esto no saca también el click corto
            }
        });

    }
}