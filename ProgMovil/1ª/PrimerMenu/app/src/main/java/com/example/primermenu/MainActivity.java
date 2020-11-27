package com.example.primermenu;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public boolean onCreateOptionsMenu(Menu menu)
    {
        MenuInflater mi = getMenuInflater();
        mi.inflate(R.menu.menu_principal, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item)
    {
        Intent i;
        switch(item.getItemId())
        {

            case R.id.itemFotocasa:
                i = new Intent("android.intent.action.VIEW", Uri.parse("https://www.fotocasa.es/es/"));
                startActivity(i);
                break;

            case R.id.itemIdealista:
                i = new Intent("android.intent.action.VIEW", Uri.parse("https://www.idealista.com"));
                startActivity(i);
                break;

            case R.id.itemMilanuncios:
                i = new Intent("android.intent.action.VIEW", Uri.parse("https://www.milanuncios.com"));
                startActivity(i);
                break;

            case R.id.itemVanguardia:
                i = new Intent("android.intent.action.VIEW", Uri.parse("https://www.lavanguardia.com"));
                startActivity(i);
                break;

            case R.id.itemInfolibre:
                i = new Intent("android.intent.action.VIEW", Uri.parse("https://www.infolibre.es"));
                startActivity(i);
                break;

            case R.id.itemConfidencial:
                i = new Intent("android.intent.action.VIEW", Uri.parse("https://www.elconfidencial.com"));
                startActivity(i);
                break;
        }

        return true;
    }
}