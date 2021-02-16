package com.example.fragmentos;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        FragmentManager fm = this.getSupportFragmentManager();
        FragmentTransaction ft = fm.beginTransaction();
        FragmentInicial fi = new FragmentInicial();

        ft.add(R.id.linearFragmentos, fi);
        ft.commit();
    }

    public void seleccionarFragment(View v)
    {
        Fragment miFragmento;

        if(v == findViewById(R.id.btnFragmento1))
            miFragmento = new FragmentInicial();
        else if(v == findViewById(R.id.btnFragmento2))
            miFragmento = new FragmentoSegundo();
        else if(v == findViewById(R.id.btnFragmento3))
            miFragmento = new FragmentoTercero();
        else
            miFragmento = new FragmentInicial();

        FragmentTransaction transaction = getSupportFragmentManager().beginTransaction();
        transaction.replace(R.id.linearFragmentos, miFragmento);
        transaction.addToBackStack(null);
        transaction.commit();
    }
}