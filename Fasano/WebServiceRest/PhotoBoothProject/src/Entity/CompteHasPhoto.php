<?php

namespace App\Entity;

use ApiPlatform\Core\Annotation\ApiResource as ApiResource;
use Doctrine\ORM\Mapping as ORM;

/**
 * CompteHasPhoto
 *
 * @ORM\Table(name="compte_has_photo", indexes={@ORM\Index(name="fk_Compte_has_Photo_Photo1_idx", columns={"Photo_idPhoto"}), @ORM\Index(name="fk_Compte_has_Photo_Evenements1_idx", columns={"Evenements_idEvenements"}), @ORM\Index(name="fk_Compte_has_Photo_Compte_idx", columns={"Compte_idCompte"})})
 * @ApiResource
 * @ORM\Entity
 */
class CompteHasPhoto
{
    /**
     * @var \Compte
     *
     * @ORM\Id
     * @ORM\GeneratedValue(strategy="NONE")
     * @ORM\OneToOne(targetEntity="Compte")
     * @ORM\JoinColumns({
     *   @ORM\JoinColumn(name="Compte_idCompte", referencedColumnName="idCompte")
     * })
     */
    private $compteIdcompte;

    /**
     * @var \Evenements
     *
     * @ORM\ManyToOne(targetEntity="Evenements")
     * @ORM\JoinColumns({
     *   @ORM\JoinColumn(name="Evenements_idEvenements", referencedColumnName="idEvenements")
     * })
     */
    private $evenementsIdevenements;

    /**
     * @var \Photo
     *
     * @ORM\Id
     * @ORM\GeneratedValue(strategy="NONE")
     * @ORM\OneToOne(targetEntity="Photo")
     * @ORM\JoinColumns({
     *   @ORM\JoinColumn(name="Photo_idPhoto", referencedColumnName="idPhoto")
     * })
     */
    private $photoIdphoto;

    public function getCompteIdcompte(): ?Compte
    {
        return $this->compteIdcompte;
    }

    public function setCompteIdcompte(?Compte $compteIdcompte): self
    {
        $this->compteIdcompte = $compteIdcompte;

        return $this;
    }

    public function getEvenementsIdevenements(): ?Evenements
    {
        return $this->evenementsIdevenements;
    }

    public function setEvenementsIdevenements(?Evenements $evenementsIdevenements): self
    {
        $this->evenementsIdevenements = $evenementsIdevenements;

        return $this;
    }

    public function getPhotoIdphoto(): ?Photo
    {
        return $this->photoIdphoto;
    }

    public function setPhotoIdphoto(?Photo $photoIdphoto): self
    {
        $this->photoIdphoto = $photoIdphoto;

        return $this;
    }


}
