package com.example.almacenamientosqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    Button btnInsertar, btnBorrar, btnActualizar, btnConsultar, btnListar;
    EditText etNombre, etDireccion;
    TextView tv1;
    SQLiteDatabase bd;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnInsertar = findViewById(R.id.btnInsertar);
        btnBorrar = findViewById(R.id.btnBorrar);
        btnActualizar = findViewById(R.id.btnActualizar);
        btnConsultar = findViewById(R.id.btnConsultar);
        btnListar = findViewById(R.id.btnListar);

        btnInsertar.setOnClickListener(this);
        btnBorrar.setOnClickListener(this);
        btnActualizar.setOnClickListener(this);
        btnConsultar.setOnClickListener(this);
        btnListar.setOnClickListener(this);

        BDAgenda agenda = new BDAgenda(getApplicationContext(), "BDAgenda", null, 1); //nombre es de la base de datos, el nº permite rehacer la base
        bd = agenda.getWritableDatabase();
    }

    @Override
    public void onClick(View v) {

        String nombre = etNombre.getText().toString();
        String direcc = etDireccion.getText().toString();

        switch(v.getId())
        {
            case R.id.btnInsertar:
                bd.execSQL("INSERT INTO agenda(nombre, direccion) VALUES('"+nombre + "', '" + direcc + "')");
                etNombre.setText("");
                etDireccion.setText("");
                Toast.makeText(getApplicationContext(), "Registro insertado", Toast.LENGTH_SHORT).show();
                break;

            case R.id.btnBorrar:
                if(direcc.equals("") && !nombre.equals(""))
                {
                    bd.execSQL("DELETE FROM agenda WHERE nombre = '" + nombre + "'");
                }
                if(!direcc.equals("") && nombre.equals(""))
                {
                    bd.execSQL("DELETE FROM agenda WHERE direccion = '" + direcc + "'");
                }

                if(!direcc.equals("") && !nombre.equals(""))
                {
                    bd.execSQL("DELETE FROM agenda WHERE nombre = '" + nombre + "' AND direccion = '" + direcc + "'");
                }
                break;

            case R.id.btnActualizar:
                bd.execSQL("UPDATE agenda SET direccion='" + direcc + "' WHERE nombre = '" + nombre + "'");
                etNombre.setText("");
                etDireccion.setText("");
                Toast.makeText(getApplicationContext(), "Registro actualizado", Toast.LENGTH_SHORT).show();
                break;

            case R.id.btnConsultar:
                break;

            case R.id.btnListar:
                tv1.setText("");
                Cursor fila = bd.rawQuery("SELECT codigo, nombre, direccion FROM agenda", null);
                if(fila.moveToFirst())
                {
                    do {
                        {
                            int codigo = fila.getInt(0);
                            String nom = fila.getString(1);
                            String direcct = fila.getString(2);
                            tv1.append(codigo + "---" + nombre + "---" + direcct);
                        }
                    }
                    while(fila.moveToNext());
                    etNombre.setText("");
                    etDireccion.setText("");
                }
                else
                {
                    Toast.makeText(getApplicationContext(), "No existen datos en la tabla", Toast.LENGTH_SHORT);
                }
                break;
        }
    }
}