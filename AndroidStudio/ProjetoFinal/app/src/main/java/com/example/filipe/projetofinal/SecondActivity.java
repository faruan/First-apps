package com.example.filipe.projetofinal;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import java.util.List;

public class SecondActivity extends AppCompatActivity {

    private DBHelper dh;
    EditText etNome,etCpf, etIdade, etTel, etEmail;
    Button btInserir, btListar, btVoltar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        this.dh = new DBHelper(this);
        etNome = (EditText) findViewById(R.id.etnome);
        etCpf = (EditText) findViewById(R.id.etcpf);
        etIdade = (EditText) findViewById(R.id.etidade);
        etTel = (EditText) findViewById(R.id.ettelefone);
        etEmail = (EditText) findViewById(R.id.etemail);

        btInserir = (Button) findViewById(R.id.btinserir);
        btListar = (Button) findViewById(R.id.btlistar);
        btVoltar = (Button) findViewById(R.id.btvoltar);

        btInserir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (etNome.getText().length()>0 && etCpf.getText().length()>0 && etIdade.getText().length()>0 && etTel.getText().length()>0 && etEmail.getText().length()>0){
                    dh.insert(etNome.getText().toString(),etCpf.getText().toString(),etIdade.getText().toString(),etTel.getText().toString(),etEmail.getText().toString());
                    AlertDialog.Builder adb = new AlertDialog.Builder(SecondActivity.this);
                    adb.setTitle("Sucesso");
                    adb.setMessage("Cadastro Realizado!");
                    adb.show();

                    etNome.setText("");
                    etCpf.setText("");
                    etIdade.setText("");
                    etTel.setText("");
                    etEmail.setText("");
                }
                else{
                    AlertDialog.Builder adb = new AlertDialog.Builder(SecondActivity.this);
                    adb.setTitle("Erro");
                    adb.setMessage("Todos os campos devem ser preenchidos!");
                    adb.show();

                    etNome.setText("");
                    etCpf.setText("");
                    etIdade.setText("");
                    etTel.setText("");
                    etEmail.setText("");
                }
            }
        });

        btListar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                List<Contato> contatos = dh.queryGetAll();
                if (contatos ==null){
                    AlertDialog.Builder adb = new AlertDialog.Builder(SecondActivity.this);
                    adb.setTitle("Mensagem");
                    adb.setMessage("Não há registros cadastrados!");
                    adb.show();
                    return;
                }
                for(int i=0; i<contatos.size(); i++){
                    Contato contato = (Contato) contatos.get(i);
                    AlertDialog.Builder adb = new AlertDialog.Builder(SecondActivity.this);
                    adb.setTitle("Registro " + i);
                    adb.setMessage("Nome: "+ contato.getNome()+"\nCpf: "+ contato.getCPF()+"\nIdade: "+ contato.getIdade()+"\nTelefone: "+ contato.getTelefone()+"\nEmail: "+ contato.getEmail());
                    adb.setPositiveButton("OK", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            dialog.dismiss();
                        }
                    });
                    adb.show();
                }
            }
        });

        btVoltar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                voltarParaPrimeiraTela();
            }
        });

    }

    void voltarParaPrimeiraTela() {
        Intent intent = new Intent();
        intent.setClass(SecondActivity.this, MainActivity.class);
        startActivity(intent);
        finish();
    }
}
