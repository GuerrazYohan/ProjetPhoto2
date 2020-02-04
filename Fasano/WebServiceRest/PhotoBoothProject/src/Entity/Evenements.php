<?php

namespace App\Entity;

use ApiPlatform\Core\Annotation\ApiResource as ApiResource;
use Doctrine\ORM\Mapping as ORM;

/**
 * Evenements
 *
 * @ORM\Table(name="evenements")
 * @ApiResource
 * @ORM\Entity
 */
class Evenements
{
    /**
     * @var int
     *
     * @ORM\Column(name="idEvenements", type="integer", nullable=false)
     * @ORM\Id
     * @ORM\GeneratedValue(strategy="IDENTITY")
     */
    private $idevenements;

    /**
     * @var string
     *
     * @ORM\Column(name="Nom", type="string", length=45, nullable=false)
     */
    private $nom;

    /**
     * @var \DateTime
     *
     * @ORM\Column(name="DateDebut", type="date", nullable=false)
     */
    private $datedebut;

    /**
     * @var \DateTime
     *
     * @ORM\Column(name="DateDeFin", type="date", nullable=false)
     */
    private $datedefin;

    /**
     * @var string
     *
     * @ORM\Column(name="MotDePasseEvent", type="text", length=65535, nullable=false)
     */
    private $motdepasseevent;

    public function getIdevenements(): ?int
    {
        return $this->idevenements;
    }

    public function getNom(): ?string
    {
        return $this->nom;
    }

    public function setNom(string $nom): self
    {
        $this->nom = $nom;

        return $this;
    }

    public function getDatedebut(): ?\DateTimeInterface
    {
        return $this->datedebut;
    }

    public function setDatedebut(\DateTimeInterface $datedebut): self
    {
        $this->datedebut = $datedebut;

        return $this;
    }

    public function getDatedefin(): ?\DateTimeInterface
    {
        return $this->datedefin;
    }

    public function setDatedefin(\DateTimeInterface $datedefin): self
    {
        $this->datedefin = $datedefin;

        return $this;
    }

    public function getMotdepasseevent(): ?string
    {
        return $this->motdepasseevent;
    }

    public function setMotdepasseevent(string $motdepasseevent): self
    {
        $this->motdepasseevent = $motdepasseevent;

        return $this;
    }


}
