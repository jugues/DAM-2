package com.example.menuemergente;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private TextView tv;
    private LinearLayout ly;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tv = findViewById(R.id.tvCambiarColor);
        ly = findViewById(R.id.lyPrincipal);
        registerForContextMenu(tv);
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {

        menu.setHeaderTitle("Elija color de fondo");
        MenuInflater mi = getMenuInflater();
        mi.inflate(R.menu.menu_contextual, menu);
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {

        switch(item.getItemId())
        {
            case R.id.itemRojo:
                ly.setBackgroundColor(Color.rgb(255, 0, 0));
                break;

            case R.id.itemVerde:
                ly.setBackgroundColor(Color.rgb(0, 255, 0));
                break;

            case R.id.itemAzul:
                ly.setBackgroundColor(Color.rgb(0, 0, 255));
                break;
        }
        return true;
    }
}