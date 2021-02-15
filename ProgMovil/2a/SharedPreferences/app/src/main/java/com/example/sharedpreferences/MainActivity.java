package com.example.sharedpreferences;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private EditText et;
    SharedPreferences pref;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        et = findViewById(R.id.etBox);
        pref = this.getSharedPreferences("data", Context.MODE_PRIVATE); //archivo y preferencias privadas
        String name = pref.getString("name", " doesn't have an established name yet");
        et.setHint(name);
    }

    protected void onDestroy() { //guardamos el texto del edit text

        super.onDestroy();
        SharedPreferences.Editor editor = pref.edit();
        editor.putString("name", et.getText().toString());
        editor.commit();
        Toast.makeText(getApplicationContext(), "New name saved", Toast.LENGTH_SHORT);
    }
}