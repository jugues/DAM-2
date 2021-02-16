package com.example.almacenamientosqlite;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class BDAgenda extends SQLiteOpenHelper {

    String crearTabla = "CREATE TABLE prueba(codigo INTEGER PRIMARY KEY AUTOINCREMENT, nombre TEXT, direccion TEXT)";

    public BDAgenda(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {

        db.execSQL(crearTabla);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

        db.execSQL(crearTabla);
    }
}
