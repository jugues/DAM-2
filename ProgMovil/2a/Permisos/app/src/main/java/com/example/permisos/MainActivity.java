package com.example.permisos;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private Button btnPermisos;
    private static final int PERMISO_CONTACTOS = 100;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnPermisos = findViewById(R.id.btnPermisos);
        btnPermisos.setOnClickListener(this);
    }

    private void accederAgenda()
    {
        int permisoAgenda = ContextCompat.checkSelfPermission(this, Manifest.permission.READ_CONTACTS);

        if(permisoAgenda != PackageManager.PERMISSION_GRANTED)
        {
            Toast.makeText(getApplicationContext(), "No tiene permiso para acceder a la agenda de contactos", Toast.LENGTH_LONG).show();
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.READ_CONTACTS}, PERMISO_CONTACTOS);
        }

        else
        {
            Log.i("Mensaje", "Acceso permitido a la agenda de contactos");
            abrirAgenda();
        }
    }

    private void abrirAgenda()
    {
        Intent i = new Intent(Intent.ACTION_PICK, ContactsContract.Contacts.CONTENT_URI);
        startActivity(i);
    }

    @Override
    public void onClick(View v) {
        accederAgenda();
    }
}