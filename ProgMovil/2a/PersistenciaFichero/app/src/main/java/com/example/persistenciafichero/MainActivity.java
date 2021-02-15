package com.example.persistenciafichero;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class MainActivity extends AppCompatActivity {

    private Button btnGuardar;
    private TextView tvRuta;
    private EditText etFichero;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnGuardar = findViewById(R.id.btnGuardar);
        tvRuta = findViewById(R.id.tvRuta);
        etFichero = findViewById(R.id.etFichero);

        btnGuardar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast t;
                try {
                    OutputStreamWriter archivo = new OutputStreamWriter(openFileOutput("notas.txt", MODE_PRIVATE));
                    archivo.write(etFichero.getText().toString());
                    archivo.flush();
                    archivo.close();
                }
                 catch (IOException e) {
                    e.printStackTrace();
                    t = Toast.makeText(getApplicationContext(), "Se ha producido una excepción de E/S", Toast.LENGTH_LONG);
                    t.show();
                }

                t = Toast.makeText(getApplicationContext(), "Datos guardados correctamente", Toast.LENGTH_SHORT);
                t.show();
            }
        });

        File fichero = new File("notas.txt");
        try {
            InputStreamReader archivo = new InputStreamReader(openFileInput(fichero.getName()));
            BufferedReader bf = new BufferedReader(archivo);
            String linea = bf.readLine();
            String todo = "";

            while(linea != null)
            {
                todo+= linea +"\n";
                linea = bf.readLine(); //para que continúe recorriendo el archivo
            }

            bf.close();
            archivo.close();
            etFichero.setText(todo);
            tvRuta.setText(fichero.getAbsolutePath() + "---" + fichero.getPath() + "---" + fichero.getCanonicalPath());

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}