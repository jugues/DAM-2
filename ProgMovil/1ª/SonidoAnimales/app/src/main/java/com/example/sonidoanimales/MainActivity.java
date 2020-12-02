package com.example.sonidoanimales;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.telecom.Call;
import android.view.View;
import android.widget.AdapterView;
import android.widget.BaseAdapter;
import android.widget.GridView;

public class MainActivity extends AppCompatActivity {

    GridView gv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        gv = findViewById(R.id.gridview);
        gv.setAdapter(new Adaptador(this));

        gv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent i;
                //= new Intent(MainActivity.this, );
                i.putExtra("position", position);
                startActivity(i);
            }
        });
    }
}